namespace MathTest.Domain.Entities
{
    public class Teacher
    {
        public string Id { get; set; } = string.Empty;
        public List<Student> Students { get; set; } = new();
    }
}
