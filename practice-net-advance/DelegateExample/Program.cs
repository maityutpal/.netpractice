using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateExample
{
    internal class Program
    {
        public delegate void LogData(string logText);
        static void Main(string[] args)
        {
            string logText = Console.ReadLine();
            LogData logdel = new LogData(LogDataToConsole);
            logdel += new LogData(LogDataToScreen);
            logdel(logText);
        }
        static void LogDataToConsole(string logText)
        {
            Console.WriteLine("Console 1 "+logText);
        }

        static void LogDataToScreen(string logText)
        {
            Console.WriteLine("Screen 1 " + logText);
        }
    }
}
