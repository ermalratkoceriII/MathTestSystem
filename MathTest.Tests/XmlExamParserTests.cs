using MathTest.Infrastructure.Xml;
using System.Text;

namespace MathTest.Tests;

public class XmlExamParserTests
{
    [Fact]
    public void ParseTeacher_FromXml_ShouldParseMultipleStudentsAndExams()
    {
        // Arrange
        var xml = """
        <Teacher ID="11111">
          <Students>
            <Student ID="10001">
              <Exam Id="1">
                <Problem id="1">2+2 = 4</Problem>
              </Exam>
              <Exam Id="2">
                <Problem id="1">6/3 = 2</Problem>
                <Problem id="2">5*2 = 11</Problem>
              </Exam>
            </Student>
            <Student ID="10002">
              <Exam Id="1">
                <Problem id="1">10-4 = 6</Problem>
              </Exam>
            </Student>
          </Students>
        </Teacher>
        """;

        using var stream = new MemoryStream(Encoding.UTF8.GetBytes(xml));
        var parser = new XmlExamParser();

        // Act
        var teacher = parser.ParseTeacherFromXml(stream);

        // Assert
        Assert.Equal("11111", teacher.Id);
        Assert.Equal(2, teacher.Students.Count);

        var student1 = teacher.Students.Single(s => s.Id == "10001");
        Assert.Equal(2, student1.Exams.Count);

        var exam2 = student1.Exams.Single(e => e.Id == "2");
        Assert.Equal(2, exam2.Problems.Count);

        var student2 = teacher.Students.Single(s => s.Id == "10002");
        Assert.Single(student2.Exams);
        Assert.Single(student2.Exams[0].Problems);
    }

    [Fact]
    public void ParseTeacher_FromXml_ShouldTrimExpressionAndResult()
    {
        // Arrange
        var xml = """
        <Teacher ID="11111">
          <Students>
            <Student ID="12345">
              <Exam Id="1">
                <Problem id="1">   8/2 + 1   =   5   </Problem>
              </Exam>
            </Student>
          </Students>
        </Teacher>
        """;

        using var stream = new MemoryStream(Encoding.UTF8.GetBytes(xml));
        var parser = new XmlExamParser();

        // Act
        var teacher = parser.ParseTeacherFromXml(stream);
        var problem = teacher.Students[0].Exams[0].Problems[0];

        // Assert
        Assert.Equal("8/2 + 1", problem.Expression);
        Assert.Equal(5, problem.StudentResult);
    }

    [Fact]
    public void ParseTeacher_FromXml_InvalidProblemFormat_ShouldThrowFormatException()
    {
        // Arrange
        var xml = """
        <Teacher ID="11111">
          <Students>
            <Student ID="12345">
              <Exam Id="1">
                <Problem id="1">2+2 4</Problem>
              </Exam>
            </Student>
          </Students>
        </Teacher>
        """;

        using var stream = new MemoryStream(Encoding.UTF8.GetBytes(xml));
        var parser = new XmlExamParser();

        // Act + Assert
        Assert.Throws<FormatException>(() => parser.ParseTeacherFromXml(stream));
    }
}
