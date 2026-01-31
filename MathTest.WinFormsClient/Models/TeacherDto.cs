namespace MathTest.WinFormsClient.Models
{
    public class TeacherDto
    {
        public string Id { get; set; } = string.Empty;
        public List<StudentDto> Students { get; set; } = new();
    }
}
