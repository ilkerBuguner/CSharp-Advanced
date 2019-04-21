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
            Stack<int> stack = new Stack<int>(numbers);

            int countOfNumbersToPop = keyNumbers[1];

            for (int i = 0; i < countOfNumbersToPop; i++)
            {
                stack.Pop();
            }

            int wantedNum = keyNumbers[2];

            if (stack.Contains(wantedNum))
            {
                Console.WriteLine("true");
            }
            else
            {
                if (stack.Any())
                {
                    int currentSmalestNum = stack.Min();

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
