using System;
using System.Collections.Generic;
using System.Linq;

namespace Lab___04._Add_VAT
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<double, double> adder = x => x * 1.20;

            var numbers = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .Select(double.Parse).Select(adder).ToList();

            Action<double> format = x => Console.WriteLine($"{x:F2}");

            numbers.ForEach(format);
        }
    }
}
