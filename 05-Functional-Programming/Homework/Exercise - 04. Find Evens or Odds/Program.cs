using System;
using System.Linq;
using System.Collections.Generic;

namespace Exercise___04._Find_Evens_or_Odds
{
    class Program
    {
        public static void Main(string[] args)
        {
            int[] numbersRange = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            string oddOrEven = Console.ReadLine();
            Func<int, bool> func = filter(oddOrEven);

            for (int i = numbersRange[0]; i <= numbersRange[1]; i++)
            {
                if (func(i))
                {
                    Console.Write(i + " ");
                }
            }

        }

        private static Func<int, bool> filter(string oddOrEven)
        {
            if (oddOrEven == "even")
            {
                return x => x % 2 == 0;
            }

            return x => x % 2 != 0;
        }
    }
}
