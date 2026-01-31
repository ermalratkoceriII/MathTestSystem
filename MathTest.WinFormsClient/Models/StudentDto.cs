namespace MathTest.WinFormsClient.Models
{
    /// <summary>
    /// The student.
    /// </summary>
    public class StudentDto
    {
        /// <summary>
        /// Student Id.
        /// </summary>
        public string Id { get; set; } = string.Empty;

        /// <summary>
        /// Students exams.
        /// </summary>
        public List<ExamDto> Exams { get; set; } = new();
    }
}
