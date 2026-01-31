using MathTest.Engine.Interfaces;
using System.Data;

namespace MathTest.Engine.Services
{
    public class Evaluator : IEvaluator
    {
       public double Evaluate(string expression)
        {
            var table = new DataTable();

            return Convert.ToDouble(table.Compute(expression, string.Empty));
        }
    }
}