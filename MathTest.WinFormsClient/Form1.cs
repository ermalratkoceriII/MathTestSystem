using MathTest.Domain.Entities;
using MathTest.WinFormsClient.Models;
using System.Net.Http.Headers;
using System.Text.Json;

namespace MathTest.WinFormsClient;

public partial class Form1 : Form
{
    // Change port if needed (use the one your API runs on)
    private const string ApiBaseUrl = "http://localhost:35660";

    private readonly HttpClient _httpClient = new();
    private TeacherDto? _lastTeacher;

    public Form1()
    {
        InitializeComponent();

        // basic grid config
        gridProblems.AutoGenerateColumns = true;
        gridProblems.ReadOnly = true;
        gridProblems.AllowUserToAddRows = false;
        gridProblems.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

        lstStudents.SelectedIndexChanged += (_, _) => OnStudentSelected();
        cmbExams.SelectedIndexChanged += (_, _) => OnExamSelected();
        btnUploadXml.Click += async (_, _) => await UploadXmlAsync();
    }

    private async Task UploadXmlAsync()
    {
        using var dialog = new OpenFileDialog
        {
            Filter = "XML files (*.xml)|*.xml|All files (*.*)|*.*",
            Title = "Select exam XML file"
        };

        if (dialog.ShowDialog() != DialogResult.OK)
            return;

        lblStatus.Text = "Status: Uploading...";
        lblSummary.Text = "";

        try
        {
            using var form = new MultipartFormDataContent();

            var bytes = await File.ReadAllBytesAsync(dialog.FileName);
            var fileContent = new ByteArrayContent(bytes);
            fileContent.Headers.ContentType = new MediaTypeHeaderValue("text/xml");

            // IMPORTANT: this "File" name must match UploadExamRequest.File
            form.Add(fileContent, "File", Path.GetFileName(dialog.FileName));

            var response = await _httpClient.PostAsync($"{ApiBaseUrl}/api/Exams/upload", form);
            response.EnsureSuccessStatusCode();

            var json = await response.Content.ReadAsStringAsync();

            var options = new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            };

            _lastTeacher = JsonSerializer.Deserialize<TeacherDto>(json, options);

            if (_lastTeacher == null)
                throw new Exception("Could not deserialize server response.");

            BindTeacher(_lastTeacher);
            BindStudentView(_lastTeacher);

            lblStatus.Text = "Status: Uploaded & graded ✅";
        }
        catch (Exception ex)
        {
            lblStatus.Text = "Status: Error ❌";
            MessageBox.Show(ex.Message, "Upload failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void BindTeacher(TeacherDto teacher)
    {
        lstStudents.DataSource = null;
        lstStudents.DisplayMember = "Id";
        lstStudents.DataSource = teacher.Students;

        cmbExams.DataSource = null;
        gridProblems.DataSource = null;

        lblSummary.Text = $"Teacher: {teacher.Id}, Students: {teacher.Students.Count}";
    }

    private void OnStudentSelected()
    {
        if (lstStudents.SelectedItem is not StudentDto student)
            return;

        cmbExams.DataSource = null;
        cmbExams.DisplayMember = "Id";
        cmbExams.DataSource = student.Exams;

        // auto-select first exam
        if (student.Exams.Count > 0)
            cmbExams.SelectedIndex = 0;

        UpdateSummary(student, cmbExams.SelectedItem as ExamDto);
    }

    private void OnExamSelected()
    {
        if (lstStudents.SelectedItem is not StudentDto student)
            return;

        if (cmbExams.SelectedItem is not ExamDto exam)
            return;

        gridProblems.DataSource = null;
        gridProblems.DataSource = exam.Problems;

        UpdateSummary(student, exam);
    }

    private void UpdateSummary(StudentDto student, ExamDto? exam)
    {
        if (exam == null)
        {
            lblSummary.Text = $"Student: {student.Id}";
            return;
        }

        var total = exam.Problems.Count;
        var correct = exam.Problems.Count(p => p.IsCorrect);

        var percentage = total == 0
            ? 0
            : (double)correct / total * 100;

        lblSummary.Text = $"Student: {student.Id} | Exam: {exam.Id} | Score: {correct}/{total} | ({percentage:0}%)";
    }

    private void BindStudentView(TeacherDto teacher)
    {
        cmbStudentId.DataSource = null;
        cmbStudentId.DisplayMember = "Id";
        cmbStudentId.DataSource = teacher.Students;

        cmbStudentId.SelectedIndexChanged += (_, _) => OnStudentViewStudentSelected();
        cmbStudentExam.SelectedIndexChanged += (_, _) => OnStudentViewExamSelected();

        if (teacher.Students.Count > 0)
            cmbStudentId.SelectedIndex = 0;
    }

    private void OnStudentViewStudentSelected()
    {
        if (cmbStudentId.SelectedItem is not StudentDto student)
            return;

        cmbStudentExam.DataSource = null;
        cmbStudentExam.DisplayMember = "Id";
        cmbStudentExam.DataSource = student.Exams;

        if (student.Exams.Count > 0)
            cmbStudentExam.SelectedIndex = 0;

        UpdateStudentSummary(student, cmbStudentExam.SelectedItem as ExamDto);
    }

    private void OnStudentViewExamSelected()
    {
        if (cmbStudentId.SelectedItem is not StudentDto student)
            return;

        if (cmbStudentExam.SelectedItem is not ExamDto exam)
            return;

        gridStudentProblems.DataSource = null;
        gridStudentProblems.DataSource = exam.Problems;

        UpdateStudentSummary(student, exam);
    }

    private void UpdateStudentSummary(StudentDto student, ExamDto? exam)
    {
        if (exam == null)
        {
            lblStudentSummary.Text = $"Student: {student.Id}";
            return;
        }

        var total = exam.Problems.Count;
        var correct = exam.Problems.Count(p => p.IsCorrect);
        var percentage = total == 0 ? 0 : (double)correct / total * 100;

        lblStudentSummary.Text =
            $"Student: {student.Id} | Exam: {exam.Id} | Score: {correct}/{total} ({percentage:0}%)";
    }
}
