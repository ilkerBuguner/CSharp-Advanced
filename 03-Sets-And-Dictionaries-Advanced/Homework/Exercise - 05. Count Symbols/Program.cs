using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercise___05._Count_Symbols
{
    class Program
    {
        static void Main(string[] args)
        {
            var occurrences = new Dictionary<char, int>();

            string input = Console.ReadLine();

            for (int i = 0; i < input.Length; i++)
            {
                char currentSymbol = input[i];

                if (!occurrences.ContainsKey(currentSymbol))
                {
                    occurrences[currentSymbol] = 0;
                }

                occurrences[currentSymbol]++;
            }

            foreach (var kvp in occurrences.OrderBy(x => x.Key))
            {
                Console.WriteLine($"{kvp.Key}: {kvp.Value} time/s");
            }
        }
    }
}
