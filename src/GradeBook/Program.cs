using System;
using System.Collections.Generic;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] numbers = new[] { 12.7, 10.3, 6.11, 4.1 };
            List<double> grades = new List<double>();
            // numbers[0] = 12.7;
            // numbers[1] = 10.5;
            // numbers[2] = 16.8;
            var result = 0.0;
            foreach (double number in numbers)
            {
                result += number;
            }
            // var result = numbers[0];
            // result += numbers[1];
            // result += numbers[2];
            // double x = 34.1;
            // double y = 10.3;

            // var result = x + y;

            Console.WriteLine(result);

            if(args.Length > 0)
            {
                Console.WriteLine($"Hello, {args[0]}!");
            }
            else 
            {
                Console.WriteLine("Hello!");
            }
        }
    }
}
