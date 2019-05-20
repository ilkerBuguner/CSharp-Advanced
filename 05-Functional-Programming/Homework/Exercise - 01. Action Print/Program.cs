using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercise___01._Action_Print
{
    class Program
    {
        static void Main(string[] args)
        {
            var names = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToList();

            Action<string> printer = x => Console.WriteLine(x);

            names.ForEach(printer);

        }
    }
}
