using System;
using System.Globalization;
using System.Threading;
using static System.Console;

namespace Stopwatch
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }

        static void Start(int currentTime)
        {
            
            int pastTime = 10;

            while (currentTime != pastTime)
            {
                Clear();
                currentTime++;
                WriteLine(currentTime);
                Thread.Sleep(100);
            }
            Clear();
            WriteLine($"Stopwatch ended");
            Thread.Sleep(1500);
        }

        static void Menu()
        {
            Clear();
            WriteLine($"Do you want to count in minutes or in seconds?");
            WriteLine($"***** [ M ] Minutes           *****");
            WriteLine($"***** [ S ] Seconds           *****");
            WriteLine($"***** [ L ] Leave application *****");
            
            
            WriteLine($" How much time do you want to count?");
            string timeAndType = ReadLine().ToLower();
            char typeOfTime = char.Parse(timeAndType.Substring((timeAndType.Length - 1), 1));
            int finalTime = int.Parse(timeAndType.Substring(0, timeAndType.Length - 1));
            
             
        }
        
    }
}
