namespace MathTest.Domain.Entities
{
    public class Exam
    {
        public string Id { get; set; } = string.Empty;
        public List<MathProblem> Problems { get; set; } = new();
    }
}
