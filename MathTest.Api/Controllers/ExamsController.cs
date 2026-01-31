using MathTest.Api.Models;
using MathTest.Application.Interfaces;
using MathTest.Domain.Entities;
using MathTest.Infrastructure.Xml;
using Microsoft.AspNetCore.Mvc;

namespace MathTest.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ExamsController : ControllerBase
{
    private readonly IXmlExamParser _xmlExamParser;
    private readonly IExamProcessor _examProcessor;

    public ExamsController(IXmlExamParser xmlExamParser, IExamProcessor examProcessor)
    {
        _xmlExamParser = xmlExamParser;
        _examProcessor = examProcessor;
    }

    [HttpPost("upload")]
    [Consumes("multipart/form-data")]
    public async Task<IActionResult> Upload([FromForm] UploadExamRequest request)
    {
        if (request.File == null || request.File.Length == 0)
            return BadRequest("File is missing or empty.");

        await using var stream = request.File.OpenReadStream();

        var teacher = _xmlExamParser.ParseTeacherFromXml(stream);

        foreach (var student in teacher.Students)
        {
            foreach (var exam in student.Exams)
            {
                _examProcessor.ProcessExam(exam);
            }
        }

        return Ok(teacher); // or Ok(response DTO) if you did that earlier
    }
}
