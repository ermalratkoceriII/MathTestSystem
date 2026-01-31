namespace MathTest.Domain.Entities
{
    /// <summary>
    /// The student.
    /// </summary>
    public class Student
    {
        /// <summary>
        /// Student Id.
        /// </summary>
        public string Id { get; set; } = string.Empty;

        /// <summary>
        /// Students exams.
        /// </summary>
        public List<Exam> Exams { get; set; } = new();
    }
}