namespace MathTest.WinFormsClient.Models
{
    public class ProblemDto
    {
        public string Id { get; set; } = string.Empty;
        public string Expression { get; set; } = string.Empty;
        public double StudentResult { get; set; }
        public double CorrectResult { get; set; }
        public bool IsCorrect { get; set; }
    }
}
