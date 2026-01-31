namespace MathTest.Application.Models
{
    /// <summary>
    /// Result of the exam.
    /// </summary>
    public class ExamResult
    {
        /// <summary>
        /// Id of the exam.
        /// </summary>
        public string ExamId { get; set; } = string.Empty;

        /// <summary>
        /// Total mathematical problems in the exam.
        /// </summary>
        public int TotalProblems { get; set; }

        /// <summary>
        /// Total correctly answered problems in the exam.
        /// </summary>
        public int CorrectProblems { get; set; }

        /// <summary>
        /// The score percentage of the student.
        /// </summary>
        public double ScorePercentage =>
            TotalProblems == 0 ? 0 : (double)CorrectProblems / TotalProblems * 100;
    }
}
