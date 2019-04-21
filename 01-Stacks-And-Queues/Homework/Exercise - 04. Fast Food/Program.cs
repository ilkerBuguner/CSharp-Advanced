using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercise___04._Fast_Food
{
    class Program
    {
        static void Main(string[] args)
        {
            int foodQuantityForDay = int.Parse(Console.ReadLine());

            int[] quantityPerOrderArray = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Queue<int> quantityPerOrderStack = new Queue<int>(quantityPerOrderArray);

            Console.WriteLine(quantityPerOrderArray.Max());

            while (true)
            {
                if (quantityPerOrderStack.Any())
                {

                    if (foodQuantityForDay - quantityPerOrderStack.Peek() >= 0)
                    {
                        foodQuantityForDay -= quantityPerOrderStack.Dequeue();

                    }
                    else
                    {
                        Console.WriteLine($"Orders left: {string.Join(" ", quantityPerOrderStack)}");
                        return;
                    }
                }
                else
                {
                    Console.WriteLine("Orders complete");
                    return;
                }
            }
        }
    }
}
