using MathTest.Infrastructure.Xml;
using System.Text;

namespace MathTest.Tests
{
    public class MathTestSystemTests
    {
        [Fact]
        public void ParseTeacher_FromXml_ShouldParseValidXml()
        {
            var xml = """
                <Teacher ID="11111">
                  <Students>
                    <Student ID="12345">
                      <Exam Id="1">
                        <Task id="1">2+3/6-4 = 74</Task>
                      </Exam>
                    </Student>
                  </Students>
                </Teacher>
                """;

            using var stream = new MemoryStream(
                Encoding.UTF8.GetBytes(xml));

            var parser = new XmlExamParser();

            var teacher = parser.ParseTeacherFromXml(stream);

            Assert.Equal("11111", teacher.Id);
            Assert.Single(teacher.Students);
            Assert.Single(teacher.Students[0].Exams);
        }
    }
}