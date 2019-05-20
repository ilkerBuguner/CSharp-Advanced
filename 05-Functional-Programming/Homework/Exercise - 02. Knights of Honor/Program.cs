using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercise___02._Knights_of_Honor
{
    class Program
    {
        static void Main(string[] args)
        {
            var names = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToList();

            Action<string> printerWithSir = x => Console.WriteLine($"Sir {x}");

            names.ForEach(printerWithSir);
        }
    }
}
