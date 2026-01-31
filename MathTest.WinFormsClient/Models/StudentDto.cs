namespace MathTest.WinFormsClient.Models
{
    public class StudentDto
    {
        public string Id { get; set; } = string.Empty;
        public List<ExamDto> Exams { get; set; } = new();
    }
}
