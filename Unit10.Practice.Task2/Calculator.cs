using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unit10.Practice.Task2
{

    public interface ICalculator
    {

        double Calculate(double x, double y);

    }

    public class Calculator : ICalculator
    {
        ILogger Logger { get; }

        public Calculator(ILogger logger)
        {
            Logger = logger;
        }

        public double Calculate(double x, double y)
        {
            Logger.Event("Результат работы калькулятора:");
            return x + y;
        }

    }
}
