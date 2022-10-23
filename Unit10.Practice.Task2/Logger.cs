using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unit10.Practice.Task2
{

    public interface ILogger
    {
        void Event(string message);
        void Error(string message);
        void DefaultSettings();
    }

    public class Logger : ILogger
    {

        public void DefaultSettings()
        {
            Console.ForegroundColor = ConsoleColor.White;
        }

        public void Error(string message)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(message);
        }

        public void Event(string message)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(message);
        }

    }
}
