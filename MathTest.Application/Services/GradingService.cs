using MathTest.Application.Interfaces;
using MathTest.Domain.Entities;
using MathTest.Engine.Interfaces;

namespace MathTest.Application.Services
{
    public class GradingService : IGradingService
    {
        private readonly IEvaluator _evaluator;

        public GradingService(IEvaluator evaluator)
        {
            _evaluator = evaluator; 
        }

        public void GradeWork(MathProblem studentWork)
        {
            studentWork.CorrectResult = _evaluator.Evaluate(studentWork.Expression);

            studentWork.IsCorrect = Math.Abs(studentWork.CorrectResult - studentWork.StudentResult) < 0.0001;
        }
    }
}
