using System;
using System.Collections.Generic;

namespace GradeBook
{
    class Book
    {
        private List<double> grades;
        private string name;

        public Book(string name)
        {
            grades = new List<double>(); 
            this.name = name;  
        }
        public void AddGrade(double grade)
        {
            grades.Add(grade);
        }

        public void ShowStatistics()
        {
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


            List<double> stats = new List<double>(){result, highGrade,lowGrade};
            // N1 is the amount of decimals spaces after the point.
            Console.WriteLine($"The average grade is {result:N1}!");
            Console.WriteLine($"The lowest grade is {lowGrade:N1}!");
            Console.WriteLine($"The highest grade is {highGrade:N1}!");
        }
    }
}