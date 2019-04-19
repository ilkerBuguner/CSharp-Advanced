using System;
using System.Collections.Generic;
using System.Linq;

namespace Lab___5._Print_Even_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            Queue<int> queue = new Queue<int>(numbers);
            Queue<int> queueWithValidNumbers = new Queue<int>();

            while (queue.Any())
            {
                int number = queue.Dequeue();
                if (number % 2 == 0)
                {
                    queueWithValidNumbers.Enqueue(number);
                }
            }

            Console.WriteLine(string.Join(", ", queueWithValidNumbers));
        }
    }
}
