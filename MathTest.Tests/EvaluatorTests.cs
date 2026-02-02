using MathTest.Engine.Services;

namespace MathTest.Tests;

public class EvaluatorTests
{
    [Theory]
    [InlineData("2+3*4", 14)]
    [InlineData("10-6/3", 8)]
    [InlineData("8/2+5", 9)]
    [InlineData("7*2-4", 10)]
    public void Evaluate_ValidExpressions_ReturnsCorrectResult(string expression, double expected)
    {
        // Arrange
        var evaluator = new Evaluator();

        // Act
        var result = evaluator.Evaluate(expression);

        // Assert
        Assert.Equal(expected, result, 6); // tolerance for floating point
    }
}
