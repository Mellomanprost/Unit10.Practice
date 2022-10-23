using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unit10.Practice.Task2
{
    class Program
    {

        static ILogger Logger { get; set; }

        static void Main(string[] args)
        {
            Logger = new Logger();
            var calculator = new Calculator(Logger);
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
                    Console.WriteLine("{0} + {1} = {2}", a, b, calculator.Calculate(a, b));
                    Logger.DefaultSettings();
                }
                catch (Exception exception)
                {
                    Logger.Error("Ошибка!");
                    Console.WriteLine(exception.Message);
                    Logger.DefaultSettings();
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
}
