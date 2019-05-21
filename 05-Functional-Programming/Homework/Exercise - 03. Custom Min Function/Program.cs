using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercise___03._Custom_Min_Function
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).ToArray();

            Func<int[], int[]> printMinNum = x =>
            {
                int minNum = int.MaxValue;
                for (int i = 0; i < numbers.Length; i++)
                {
                    if (numbers[i] < minNum)
                    {
                        minNum = numbers[i];
                    }

                }

                Console.WriteLine(minNum);
                return x;
            };

            printMinNum(numbers);
        }
    }
}
