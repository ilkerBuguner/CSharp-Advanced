using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercise___04._Even_Times
{
    class Program
    {
        static void Main(string[] args)
        {
            var occurrences = new Dictionary<int, int>();

            int timesToRead = int.Parse(Console.ReadLine());

            for (int i = 0; i < timesToRead; i++)
            {
                int number = int.Parse(Console.ReadLine());

                if (!occurrences.ContainsKey(number))
                {
                    occurrences[number] = 0;
                }

                occurrences[number]++;
            }

            foreach (var kvp in occurrences)
            {
                if (kvp.Value % 2 == 0)
                {
                    Console.WriteLine(kvp.Key);
                    break;
                }
            }

        }
    }
}
