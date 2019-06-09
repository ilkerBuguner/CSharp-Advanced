using System;
using System.Linq;
using System.Collections.Generic;

namespace Exercise___09._List_Of_Predicates
{
    class Program
    {
        static void Main(string[] args)
        {
            int numbersRange = int.Parse(Console.ReadLine());
            var dividers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            List<int> nums = new List<int>(Enumerable.Range(1, numbersRange));

            foreach (var divider in dividers)
            {
                Func<int, bool> filter = Filter(divider);
                nums = nums.Where(filter).ToList();
            }

            Console.WriteLine(string.Join(" ", nums));
        }

        public static Func<int, bool> Filter(int num)
        {
            return x => x % num == 0;
        }
    }
}
