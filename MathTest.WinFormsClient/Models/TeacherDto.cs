namespace MathTest.WinFormsClient.Models
{
    /// <summary>
    /// The Teacher.
    /// </summary>
    public class TeacherDto
    {
        /// <summary>
        /// Teachers Id.
        /// </summary>
        public string Id { get; set; } = string.Empty;

        /// <summary>
        /// Teachers Students.
        /// </summary>
        public List<StudentDto> Students { get; set; } = new();
    }
}