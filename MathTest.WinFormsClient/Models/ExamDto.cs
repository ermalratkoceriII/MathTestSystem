namespace MathTest.WinFormsClient.Models
{
    /// <summary>
    /// Students Exam.
    /// </summary>
    public class ExamDto
    {
        /// <summary>
        /// Id of the exam.
        /// </summary>
        public string Id { get; set; } = string.Empty;

        /// <summary>
        /// Mathematical problems on the exam.
        /// </summary>
        public List<ProblemDto> Problems { get; set; } = new();
    }
}