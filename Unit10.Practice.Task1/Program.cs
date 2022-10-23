using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unit10.Practice.Task1
{
    class Program
    {

        static void Main(string[] args)
        {
            bool flagForExit = false;
            Console.WriteLine("Программа для суммирования двух чисел.");
            do
            {
                try
                {
                    Console.WriteLine("Введите первое число: ");

                    var a = double.Parse(Console.ReadLine());

                    Console.WriteLine("Введите второе число: ");

                    var b = double.Parse(Console.ReadLine());

                    Calculator calculator = new Calculator();
                    Console.WriteLine("{0} + {1} = {2}", a, b, calculator.Calculate(a, b));
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    Console.WriteLine(ex);
                }
                finally
                {
                    Console.WriteLine("Чтобы выйти напишите - выход.\nДля продолжения нажмите Enter...");
                    var userString = Console.ReadLine();
                    if (userString == "выход" || userString == "Выход")
                    {
                        flagForExit = true;
                    }
                }
            } while (!flagForExit);


        }
    }

    public interface ICalculator
    {
        double Calculate(double x, double y);
    }

    public class Calculator : ICalculator
    {

        public double Calculate(double x, double y)
        {
            return x + y;
        }

    }
}
