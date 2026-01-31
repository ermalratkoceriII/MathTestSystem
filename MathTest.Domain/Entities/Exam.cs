namespace MathTest.Domain.Entities
{
    /// <summary>
    /// Students Exam.
    /// </summary>
    public class Exam
    {
        /// <summary>
        /// Id of the exam.
        /// </summary>
        public string Id { get; set; } = string.Empty;

        /// <summary>
        /// Mathematical problems on the exam.
        /// </summary>
        public List<MathProblem> Problems { get; set; } = new();
    }
}
