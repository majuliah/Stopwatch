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

        static void Start(int time)
        {
            
            int currentTime = 0;

            while (currentTime != time)
            {
                Clear();
                currentTime++;
                WriteLine(currentTime);
                Thread.Sleep(1000);
            }
            Clear();
            WriteLine($"Stopwatch ended");
            Thread.Sleep(1500);
        }

        static void PreStart(int time)
        {
            Clear();
            WriteLine($"READY??.......");
            Thread.Sleep(1000);
            WriteLine($"SET.......");
            Thread.Sleep(1000);
            WriteLine($"GO!");
            Thread.Sleep(1000);
            Start(time);
            
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

            int multiplier = 1;
            if (typeOfTime == 'm')
                multiplier = 60;

            if (finalTime == 0)
                System.Environment.Exit(0);

            int clock = finalTime * multiplier;
            PreStart(clock);
        }
        
    }
}
