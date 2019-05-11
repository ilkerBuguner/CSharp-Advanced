using System;
using System.Collections.Generic;
using System.Linq;

namespace Lab___02._Sum_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();

            Action<int[]> action = x => Console.WriteLine(x.Length);
            action += x => Console.WriteLine(x.Sum());

            action(numbers);
        }
    }
}
