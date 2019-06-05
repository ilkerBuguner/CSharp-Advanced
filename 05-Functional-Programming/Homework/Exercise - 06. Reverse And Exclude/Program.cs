using System;
using System.Linq;
using System.Collections.Generic;

namespace Exercise___06._Reverse_And_Exclude
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split().Select(int.Parse).ToArray().Reverse();
            int numToDivide = int.Parse(Console.ReadLine());

            Func<int, bool> divideChecker = x => x % numToDivide != 0;

            numbers.Where(divideChecker).ToList().ForEach(x => Console.Write(x + " "));

        }
    }
}
