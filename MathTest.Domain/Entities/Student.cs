namespace MathTest.Domain.Entities
{
    public class Student
    {
        public string Id { get; set; } = string.Empty;
        public List<Exam> Exams { get; set; } = new();
    }
}
