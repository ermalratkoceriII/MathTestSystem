using MathTest.Domain.Entities;

namespace MathTest.Infrastructure.Xml
{
    public interface IXmlExamParser
    {
        Teacher ParseTeacherFromXml(Stream xmlStream);
    }
}
