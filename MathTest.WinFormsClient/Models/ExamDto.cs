namespace MathTest.WinFormsClient.Models
{
    public class ExamDto
    {
        public string Id { get; set; } = string.Empty;
        public List<ProblemDto> Problems { get; set; } = new();
    }
}
