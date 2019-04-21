using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercise___01._Basic_Stack_Operations
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] keyNumbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Queue<int> queue = new Queue<int>(numbers);

            int countOfNumbersToPop = keyNumbers[1];

            for (int i = 0; i < countOfNumbersToPop; i++)
            {
                queue.Dequeue();
            }

            int wantedNum = keyNumbers[2];

            if (queue.Contains(wantedNum))
            {
                Console.WriteLine("true");
            }
            else
            {
                if (queue.Any())
                {
                    int currentSmalestNum = queue.Min();

                    Console.WriteLine(currentSmalestNum);

                }
                else
                {
                    Console.WriteLine("0");
                }
            }
        }
    }
}
