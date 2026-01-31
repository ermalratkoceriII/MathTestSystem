namespace MathTest.WinFormsClient
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnUploadXml = new Button();
            lblStatus = new Label();
            lstStudents = new ListBox();
            cmbExams = new ComboBox();
            gridProblems = new DataGridView();
            lblSummary = new Label();
            tabMain = new TabControl();
            tabTeacher = new TabPage();
            tabStudent = new TabPage();
            lblStudentSummary = new Label();
            gridStudentProblems = new DataGridView();
            cmbStudentExam = new ComboBox();
            label3 = new Label();
            cmbStudentId = new ComboBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)gridProblems).BeginInit();
            tabMain.SuspendLayout();
            tabTeacher.SuspendLayout();
            tabStudent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gridStudentProblems).BeginInit();
            SuspendLayout();
            // 
            // btnUploadXml
            // 
            btnUploadXml.AccessibleName = "";
            btnUploadXml.Location = new Point(6, 6);
            btnUploadXml.Name = "btnUploadXml";
            btnUploadXml.Size = new Size(171, 25);
            btnUploadXml.TabIndex = 0;
            btnUploadXml.Text = "Upload Exams";
            btnUploadXml.UseVisualStyleBackColor = true;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Location = new Point(310, 9);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(53, 15);
            lblStatus.TabIndex = 1;
            lblStatus.Text = "Status: - ";
            // 
            // lstStudents
            // 
            lstStudents.AccessibleName = "";
            lstStudents.FormattingEnabled = true;
            lstStudents.ItemHeight = 15;
            lstStudents.Location = new Point(6, 37);
            lstStudents.Name = "lstStudents";
            lstStudents.Size = new Size(180, 319);
            lstStudents.TabIndex = 2;
            // 
            // cmbExams
            // 
            cmbExams.AccessibleName = "";
            cmbExams.FormattingEnabled = true;
            cmbExams.Location = new Point(183, 6);
            cmbExams.Name = "cmbExams";
            cmbExams.Size = new Size(121, 23);
            cmbExams.TabIndex = 3;
            cmbExams.Text = "Exams";
            // 
            // gridProblems
            // 
            gridProblems.AccessibleName = "";
            gridProblems.AllowUserToAddRows = false;
            gridProblems.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridProblems.Location = new Point(188, 37);
            gridProblems.Name = "gridProblems";
            gridProblems.ReadOnly = true;
            gridProblems.Size = new Size(584, 319);
            gridProblems.TabIndex = 4;
            // 
            // lblSummary
            // 
            lblSummary.AutoSize = true;
            lblSummary.Location = new Point(6, 369);
            lblSummary.Name = "lblSummary";
            lblSummary.Size = new Size(12, 15);
            lblSummary.TabIndex = 5;
            lblSummary.Text = "-";
            // 
            // tabMain
            // 
            tabMain.Controls.Add(tabTeacher);
            tabMain.Controls.Add(tabStudent);
            tabMain.Location = new Point(12, 12);
            tabMain.Name = "tabMain";
            tabMain.SelectedIndex = 0;
            tabMain.Size = new Size(786, 431);
            tabMain.TabIndex = 6;
            // 
            // tabTeacher
            // 
            tabTeacher.Controls.Add(btnUploadXml);
            tabTeacher.Controls.Add(lblSummary);
            tabTeacher.Controls.Add(lblStatus);
            tabTeacher.Controls.Add(gridProblems);
            tabTeacher.Controls.Add(lstStudents);
            tabTeacher.Controls.Add(cmbExams);
            tabTeacher.Location = new Point(4, 24);
            tabTeacher.Name = "tabTeacher";
            tabTeacher.Padding = new Padding(3);
            tabTeacher.Size = new Size(778, 403);
            tabTeacher.TabIndex = 0;
            tabTeacher.Text = "Teacher";
            tabTeacher.UseVisualStyleBackColor = true;
            // 
            // tabStudent
            // 
            tabStudent.Controls.Add(lblStudentSummary);
            tabStudent.Controls.Add(gridStudentProblems);
            tabStudent.Controls.Add(cmbStudentExam);
            tabStudent.Controls.Add(label3);
            tabStudent.Controls.Add(cmbStudentId);
            tabStudent.Controls.Add(label1);
            tabStudent.Location = new Point(4, 24);
            tabStudent.Name = "tabStudent";
            tabStudent.Padding = new Padding(3);
            tabStudent.Size = new Size(778, 403);
            tabStudent.TabIndex = 1;
            tabStudent.Text = "Student";
            tabStudent.UseVisualStyleBackColor = true;
            // 
            // lblStudentSummary
            // 
            lblStudentSummary.AutoSize = true;
            lblStudentSummary.Location = new Point(434, 33);
            lblStudentSummary.Name = "lblStudentSummary";
            lblStudentSummary.Size = new Size(12, 15);
            lblStudentSummary.TabIndex = 6;
            lblStudentSummary.Text = "-";
            // 
            // gridStudentProblems
            // 
            gridStudentProblems.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridStudentProblems.Location = new Point(3, 74);
            gridStudentProblems.Name = "gridStudentProblems";
            gridStudentProblems.Size = new Size(766, 323);
            gridStudentProblems.TabIndex = 5;
            // 
            // cmbStudentExam
            // 
            cmbStudentExam.FormattingEnabled = true;
            cmbStudentExam.Location = new Point(74, 45);
            cmbStudentExam.Name = "cmbStudentExam";
            cmbStudentExam.Size = new Size(121, 23);
            cmbStudentExam.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(17, 53);
            label3.Name = "label3";
            label3.Size = new Size(38, 15);
            label3.TabIndex = 3;
            label3.Text = "Exam ";
            // 
            // cmbStudentId
            // 
            cmbStudentId.FormattingEnabled = true;
            cmbStudentId.Location = new Point(74, 11);
            cmbStudentId.Name = "cmbStudentId";
            cmbStudentId.Size = new Size(121, 23);
            cmbStudentId.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 14);
            label1.Name = "label1";
            label1.Size = new Size(62, 15);
            label1.TabIndex = 0;
            label1.Text = "Student ID";
            // 
            // Form1
            // 
            AccessibleName = "lblStatus";
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(802, 455);
            Controls.Add(tabMain);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)gridProblems).EndInit();
            tabMain.ResumeLayout(false);
            tabTeacher.ResumeLayout(false);
            tabTeacher.PerformLayout();
            tabStudent.ResumeLayout(false);
            tabStudent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)gridStudentProblems).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnUploadXml;
        private Label lblStatus;
        private ListBox lstStudents;
        private ComboBox cmbExams;
        private DataGridView gridProblems;
        private Label lblSummary;
        private TabControl tabMain;
        private TabPage tabTeacher;
        private TabPage tabStudent;
        private Label label1;
        private Label label3;
        private ComboBox cmbStudentId;
        private ComboBox cmbStudentExam;
        private Label lblStudentSummary;
        private DataGridView gridStudentProblems;
    }
}