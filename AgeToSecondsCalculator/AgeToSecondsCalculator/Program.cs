using System;
using System.Linq;

namespace AgeToSecondsCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your birthdate please. (DD/MM/YY)");
            int[] birthdate = Console.ReadLine().Split("/").Select(int.Parse).ToArray();
            Console.WriteLine("Enter your birthtime please. (HH:MM:SS)");
            int[] birthtime = Console.ReadLine().Split(":").Select(int.Parse).ToArray();

            DateTime date = DateTime.Now;

            int years = date.Year - birthdate[2] - 1;
            int months = 12 - date.Month;
            int days = date.Day - 2;

            int leapYears = (years * 5 * 60 * 60) + (years * 48 * 60) + 45;

            int yearsToSeconds = years * 365 * 24 * 60 * 60;
            int monthsToSeconds = 0;
            int daysToSeconds = days * 24 * 60 * 60;

            for(int i = 1; i <= months; i++)
            {
                if(i == 1)
                {
                    monthsToSeconds += 31 * 24 * 60 * 60;
                }
                else if(i == 2)
                {
                    monthsToSeconds += 28 * 24 * 60 * 60;
                }
                else if (i == 3)
                {
                    monthsToSeconds += 31 * 24 * 60 * 60;
                }
                else if (i == 4)
                {
                    monthsToSeconds += 30 * 24 * 60 * 60;
                }
                else if (i == 5)
                {
                    monthsToSeconds += 31 * 24 * 60 * 60;
                }
                else if (i == 6)
                {
                    monthsToSeconds += 30 * 24 * 60 * 60;
                }
                else if (i == 7)
                {
                    monthsToSeconds += 31 * 24 * 60 * 60;
                }
                else if (i == 8)
                {
                    monthsToSeconds += 31 * 24 * 60 * 60;
                }
                else if (i == 9)
                {
                    monthsToSeconds += 30 * 24 * 60 * 60;
                }
                else if (i == 10)
                {
                    monthsToSeconds += 31 * 24 * 60 * 60;
                }
                else if (i == 11)
                {
                    monthsToSeconds += 30 * 24 * 60 * 60;
                }
                else if (i == 12)
                {
                    monthsToSeconds += 31 * 24 * 60 * 60;
                }
            }

            int totalSeconds = yearsToSeconds + monthsToSeconds + daysToSeconds + leapYears;
            Console.WriteLine(totalSeconds);
        }
    }
}
