using System;
using System.Linq;
using System.Collections.Generic;

namespace _01._Socks
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] firstGivenNums = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] secondGivenNums = Console.ReadLine().Split().Select(int.Parse).ToArray();
            List<int> pairs = new List<int>();

            Stack<int> leftSocks = new Stack<int>(firstGivenNums);
            Queue<int> rightSocks = new Queue<int>(secondGivenNums);

            while (leftSocks.Any() && rightSocks.Any())
            {
                if (leftSocks.Peek() > rightSocks.Peek())
                {
                    pairs.Add(leftSocks.Pop() + rightSocks.Dequeue());
                }
                else if (leftSocks.Peek() < rightSocks.Peek())
                {
                    leftSocks.Pop();
                }
                else
                {
                    rightSocks.Dequeue();
                    int currentLastNumFromStack = leftSocks.Pop();
                    leftSocks.Push(currentLastNumFromStack + 1);
                }

            }

            Console.WriteLine(pairs.Max());
            Console.WriteLine(string.Join(" ", pairs));

        }
    }
}
