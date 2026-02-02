using MathTest.Infrastructure.Xml;

var parser = new XmlExamParser();

using var stream = File.OpenRead("sample.xml");

var teacher = parser.ParseTeacherFromXml(stream);

Console.WriteLine($"Teacher ID: {teacher.Id}");
Console.WriteLine($"Students count: {teacher.Students.Count}");

foreach (var student in teacher.Students)
{
    Console.WriteLine($" Student ID: {student.Id}");

    foreach (var exam in student.Exams)
    {
        Console.WriteLine($"  Exam ID: {exam.Id}");

        foreach (var task in exam.Problems)
        {
            Console.WriteLine(
                $"   Problem {task.Id}: {task.Expression} = {task.StudentResult}");
        }
    }
}