using MathTest.Domain.Entities;
using System.Globalization;
using System.Xml.Linq;

namespace MathTest.Infrastructure.Xml;

public class XmlExamParser : IXmlExamParser
{
    public Teacher ParseTeacherFromXml(Stream xmlStream)
    {
        var document = XDocument.Load(xmlStream);

        var teacherElement = document.Root
            ?? throw new InvalidOperationException("XML does not contain a root element.");

        var teacher = new Teacher
        {
            Id = teacherElement.Attribute("ID")?.Value ?? string.Empty
        };

        var studentsElement = teacherElement.Element("Students");
            
        if (studentsElement == null)
            return teacher;

        foreach (var studentElement in studentsElement.Elements("Student"))
        {
            var student = new Student
            {
                Id = studentElement.Attribute("ID")?.Value ?? string.Empty
            };

            foreach (var examElement in studentElement.Elements("Exam"))
            {
                var exam = new Exam
                {
                    Id = examElement.Attribute("Id")?.Value ?? string.Empty
                };

                foreach (var problemElement in examElement.Elements("Problem"))
                {
                    var rawTaskText = problemElement.Value;
                    var parsedTask = ParseProblem(rawTaskText);

                    parsedTask.Id = problemElement.Attribute("id")?.Value ?? string.Empty;

                    exam.Problems.Add(parsedTask);
                }

                student.Exams.Add(exam);
            }

            teacher.Students.Add(student);
        }

        return teacher;
    }

    private static MathProblem ParseProblem(string problemText)
    {
        // Example: "2+3/6-4 = 74"
        var parts = problemText.Split('=');

        if (parts.Length != 2)
            throw new FormatException($"Invalid task format: {problemText}");

        var expression = parts[0].Trim();
        var studentResultText = parts[1].Trim();

        return new MathProblem
        {
            Expression = expression,
            StudentResult = double.Parse(studentResultText, CultureInfo.InvariantCulture)
        };
    }
}
