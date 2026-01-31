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
            ((System.ComponentModel.ISupportInitialize)gridProblems).BeginInit();
            SuspendLayout();
            // 
            // btnUploadXml
            // 
            btnUploadXml.AccessibleName = "";
            btnUploadXml.Location = new Point(12, 12);
            btnUploadXml.Name = "btnUploadXml";
            btnUploadXml.Size = new Size(200, 25);
            btnUploadXml.TabIndex = 0;
            btnUploadXml.Text = "Upload Xml File";
            btnUploadXml.UseVisualStyleBackColor = true;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Location = new Point(218, 17);
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
            lstStudents.Location = new Point(12, 43);
            lstStudents.Name = "lstStudents";
            lstStudents.Size = new Size(200, 364);
            lstStudents.TabIndex = 2;
            // 
            // cmbExams
            // 
            cmbExams.AccessibleName = "";
            cmbExams.FormattingEnabled = true;
            cmbExams.Location = new Point(218, 43);
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
            gridProblems.Location = new Point(218, 72);
            gridProblems.Name = "gridProblems";
            gridProblems.ReadOnly = true;
            gridProblems.Size = new Size(684, 335);
            gridProblems.TabIndex = 4;
            // 
            // lblSummary
            // 
            lblSummary.AutoSize = true;
            lblSummary.Location = new Point(12, 421);
            lblSummary.Name = "lblSummary";
            lblSummary.Size = new Size(12, 15);
            lblSummary.TabIndex = 5;
            lblSummary.Text = "-";
            // 
            // Form1
            // 
            AccessibleName = "lblStatus";
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(914, 455);
            Controls.Add(lblSummary);
            Controls.Add(gridProblems);
            Controls.Add(cmbExams);
            Controls.Add(lstStudents);
            Controls.Add(lblStatus);
            Controls.Add(btnUploadXml);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)gridProblems).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnUploadXml;
        private Label lblStatus;
        private ListBox lstStudents;
        private ComboBox cmbExams;
        private DataGridView gridProblems;
        private Label lblSummary;
    }
}
