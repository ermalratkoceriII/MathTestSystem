using MathTest.Domain.Entities;

namespace MathTest.Application.Interfaces
{
    public interface IGradingService
    {
        void GradeWork(MathProblem studentWork);
    }
}