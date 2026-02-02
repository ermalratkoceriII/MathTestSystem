using MathTest.Application.Services;
using MathTest.Domain.Entities;
using MathTest.Engine.Services;

namespace MathTest.Tests;

public class GradingServiceTests
{
    [Fact]
    public void GradeTask_WhenStudentAnswerIsCorrect_ShouldMarkCorrect()
    {
        // Arrange
        var evaluator = new Evaluator();
        var gradingService = new GradingService(evaluator);

        var problem = new MathProblem
        {
            Id = "1",
            Expression = "2+2",
            StudentResult = 4
        };

        // Act
        gradingService.GradeWork(problem);

        // Assert
        Assert.True(problem.IsCorrect);
        Assert.Equal(4, problem.CorrectResult, 6);
    }

    [Fact]
    public void GradeTask_WhenStudentAnswerIsWrong_ShouldMarkIncorrect()
    {
        // Arrange
        var evaluator = new Evaluator();
        var gradingService = new GradingService(evaluator);

        var problem = new MathProblem
        {
            Id = "1",
            Expression = "10-4",
            StudentResult = 5
        };

        // Act
        gradingService.GradeWork(problem);

        // Assert
        Assert.False(problem.IsCorrect);
        Assert.Equal(6, problem.CorrectResult, 6);
    }
}
