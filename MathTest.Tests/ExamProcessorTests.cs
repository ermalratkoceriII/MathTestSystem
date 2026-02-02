using MathTest.Application.Services;
using MathTest.Domain.Entities;
using MathTest.Engine.Services;

namespace MathTest.Tests;

public class ExamProcessorTests
{
    [Fact]
    public void ProcessExam_ShouldGradeAllProblems()
    {
        // Arrange
        var evaluator = new Evaluator();
        var gradingService = new GradingService(evaluator);
        var processor = new ExamProcessor(gradingService);

        var exam = new Exam
        {
            Id = "1",
            Problems =
            {
                new MathProblem { Id = "1", Expression = "2+2", StudentResult = 4 },
                new MathProblem { Id = "2", Expression = "3*3", StudentResult = 8 }
            }
        };

        // Act
        processor.ProcessExam(exam);

        // Assert
        Assert.Equal(2, exam.Problems.Count);

        Assert.Equal(4, exam.Problems[0].CorrectResult, 6);
        Assert.True(exam.Problems[0].IsCorrect);

        Assert.Equal(9, exam.Problems[1].CorrectResult, 6);
        Assert.False(exam.Problems[1].IsCorrect);
    }
}
