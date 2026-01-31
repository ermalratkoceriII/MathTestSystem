namespace MathTest.Domain.Entities
{
    public class MathProblem
    {
        public string Id { get; set; } = string.Empty;

        public string Expression { get; set; } = string.Empty;

        public double StudentResult { get; set; }

        public double CorrectResult { get; set; }

        public bool IsCorrect { get; set; }
    }
}
