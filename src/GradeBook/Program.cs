using System;
using System.Collections.Generic;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
            Book book = new Book("Scott's Grade Book");
            book.AddGrade(89.1);
            book.AddGrade(90.5);
            book.AddGrade(77.5);

            List<double> grades = new List<double>(){ 12.7, 10.3, 6.11, 4.1 };
            grades.Add(56.1);

            // Below we are computing an average.
            var result = 0.0;
            var highGrade = double.MinValue;
            var lowGrade = double.MaxValue;
            foreach (double number in grades)
            {
                highGrade = Math.Max(number, highGrade);
                lowGrade = Math.Min(number, lowGrade);
                result += number;
            }
            result /= grades.Count;

            // N1 is the amount of decimals spaces after the point.
            Console.WriteLine($"The average grade is {result:N1}!");
            Console.WriteLine($"The lowest grade is {lowGrade:N1}!");
            Console.WriteLine($"The highest grade is {highGrade:N1}!");
        }
    }
}
