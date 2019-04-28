using System;
using System.Collections.Generic;
using System.Linq;

namespace Lab___01._Count_Same_Values_in_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] numbers = Console.ReadLine().Split().Select(double.Parse).ToArray();
            Dictionary<double, int> dict = new Dictionary<double, int>();

            for (int i = 0; i < numbers.Length; i++)
            {
                double currentNum = numbers[i];

                if (!dict.ContainsKey(currentNum))
                {
                    dict[currentNum] = 0;
                }

                dict[currentNum]++;
            }

            foreach (var kvp in dict)
            {
                Console.WriteLine($"{kvp.Key} - {kvp.Value} times");
            }

        }
    }
}
