namespace MathTest.Domain.Entities
{
    /// <summary>
    /// The Teacher.
    /// </summary>
    public class Teacher
    {
        /// <summary>
        /// Teachers Id.
        /// </summary>
        public string Id { get; set; } = string.Empty;

        /// <summary>
        /// Teachers Students.
        /// </summary>
        public List<Student> Students { get; set; } = new();
    }
}
