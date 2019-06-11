using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercise___12._Cups_and_Bottles
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] firstNumbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] secondNumbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            Queue<int> cups = new Queue<int>(firstNumbers);
            Stack<int> bottles = new Stack<int>(secondNumbers);
            int wastedWater = 0;

            //Console.WriteLine(cups.Dequeue());
            //Console.WriteLine(bottles.Pop());

            while (cups.Any() && bottles.Any())
            {
                int currentCup = cups.Peek();
                while (currentCup > 0)
                {
                    int currentBottle = bottles.Peek();
                    if (currentBottle >= currentCup)
                    { 
                        wastedWater += currentBottle - currentCup;
                        currentCup -= currentBottle;
                        cups.Dequeue();
                        bottles.Pop();
                    }
                    else if (currentCup > currentBottle)
                    {
                        currentCup -= currentBottle;
                        bottles.Pop();
                    }
                }
            }

            if (bottles.Any())
            {
                Console.WriteLine($"Bottles: {string.Join(" ", bottles)}");
                Console.WriteLine($"Wasted litters of water: {wastedWater}");
            }

            if (cups.Any())
            {
                Console.WriteLine($"Cups: {string.Join(" ", cups)}");
                Console.WriteLine($"Wasted litters of water: {wastedWater}");
            }
        }
    }
}
