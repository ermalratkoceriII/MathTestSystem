namespace MathTest.Application.Models
{
    public class ExamResult
    {
        public string ExamId { get; set; } = string.Empty;
        public int TotalProblems { get; set; }
        public int CorrectProblems { get; set; }

        public double ScorePercentage =>
            TotalProblems == 0 ? 0 : (double)CorrectProblems / TotalProblems * 100;
    }
}
