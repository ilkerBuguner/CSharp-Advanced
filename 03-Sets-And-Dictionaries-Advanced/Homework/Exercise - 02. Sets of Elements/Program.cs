using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercise___02._Sets_of_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstHashSet = new HashSet<int>();
            var secondHashSet = new HashSet<int>();

            int[] setsLength = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int firstSetLength = setsLength[0];
            int secondSetLength = setsLength[1];

            for (int i = 0; i < firstSetLength + secondSetLength; i++)
            {
                int number = int.Parse(Console.ReadLine());

                if (i < firstSetLength)
                {
                    firstHashSet.Add(number);
                }
                else
                {
                    secondHashSet.Add(number);
                    
                }
            }

            firstHashSet.IntersectWith(secondHashSet);

            Console.WriteLine(string.Join(" ", firstHashSet));
        }
    }
}
