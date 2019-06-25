using System;
using System.Linq;
using System.Collections.Generic;

namespace _01._Spaceship_Crafting
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] l = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] p = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Queue<int> liquids = new Queue<int>(l);
            Stack<int> items = new Stack<int>(p);
            int glass = 0;
            int aluminium = 0;
            int lithium = 0;
            int carbonFiber = 0;

            while (liquids.Any() && items.Any())
            {
                int currentLiquid = liquids.Peek();
                int currentItem = items.Peek();

                if (currentLiquid + currentItem == 25)
                {
                    glass++;
                    liquids.Dequeue();
                    items.Pop();
                }
                else if (currentLiquid + currentItem == 50)
                {
                    aluminium++;
                    liquids.Dequeue();
                    items.Pop();
                }
                else if (currentLiquid + currentItem == 75)
                {
                    lithium++;
                    liquids.Dequeue();
                    items.Pop();
                }
                else if (currentLiquid + currentItem == 100)
                {
                    carbonFiber++;
                    liquids.Dequeue();
                    items.Pop();
                }
                else
                {
                    liquids.Dequeue();
                    items.Push(items.Pop() + 3);
                }
            }

            if (glass > 0 && aluminium > 0 && lithium > 0 && carbonFiber > 0)
            {
                Console.WriteLine($"Wohoo! You succeeded in building the spaceship!");
            }
            else
            {
                Console.WriteLine($"Ugh, what a pity! You didn't have enough materials to build the spaceship.");
            }

            if (liquids.Count == 0)
            {
                Console.WriteLine($"Liquids left: none");
            }
            else if (liquids.Any())
            {
                Console.WriteLine($"Liquids left: {string.Join(", ", liquids)}");
            }

            if (items.Count == 0)
            {
                Console.WriteLine($"Physical items left: none");
            }
            else if (items.Any())
            {
                Console.WriteLine($"Physical items left: {string.Join(", ", items)}");
            }

            Console.WriteLine($"Aluminium: {aluminium}");
            Console.WriteLine($"Carbon fiber: {carbonFiber}");
            Console.WriteLine($"Glass: {glass}");
            Console.WriteLine($"Lithium: {lithium}");
        }
    }
}
