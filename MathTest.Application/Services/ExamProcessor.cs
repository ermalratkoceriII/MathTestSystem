using MathTest.Application.Interfaces;
using MathTest.Domain.Entities;

namespace MathTest.Application.Services
{
    public class ExamProcessor : IExamProcessor
    {
        public IGradingService _gradingService;

        public ExamProcessor(IGradingService gradingService)
        {
            _gradingService = gradingService;
        }

        public void ProcessExam(Exam exam)
        {
            foreach (var Problem in exam.Problems)
            {
                _gradingService.GradeWork(Problem);
            }
        }
    }
}