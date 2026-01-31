namespace MathTest.Domain.Entities
{
    /// <summary>
    /// Mathematical problem.
    /// </summary>
    public class MathProblem
    {
        /// <summary>
        /// Mathematical problem Id.
        /// </summary>
        public string Id { get; set; } = string.Empty;

        /// <summary>
        /// Mathematical expression.
        /// </summary>
        public string Expression { get; set; } = string.Empty;

        /// <summary>
        /// Students calculated result.
        /// </summary>
        public double StudentResult { get; set; }

        /// <summary>
        /// Correct calculated result.
        /// </summary>
        public double CorrectResult { get; set; }

        /// <summary>
        /// Correct answer indicator.
        /// </summary>
        public bool IsCorrect { get; set; }
    }
}