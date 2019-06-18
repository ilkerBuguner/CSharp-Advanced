using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Make_a_Salad
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] vegs = Console.ReadLine().Split();
            int[] cals = Console.ReadLine().Split().Select(int.Parse).ToArray();

            Queue<string> vegetables = new Queue<string>(vegs);
            Stack<int> caloriesForEachSalad = new Stack<int>(cals);
            List<int> saladsMade = new List<int>();
            bool isEnd = false;

            while (vegetables.Any() && caloriesForEachSalad.Any())
            {
                int currentCalories = caloriesForEachSalad.Peek();

                while (currentCalories > 0)
                {
                    if (vegetables.Any())
                    {
                        string currentVegetable = vegetables.Peek();

                        if (currentVegetable == "tomato")
                        {
                            currentCalories -= 80;
                            vegetables.Dequeue();

                        }
                        else if (currentVegetable == "carrot")
                        {
                            currentCalories -= 136;
                            vegetables.Dequeue();

                        }
                        else if (currentVegetable == "lettuce")
                        {
                            currentCalories -= 109;
                            vegetables.Dequeue();

                        }
                        else if (currentVegetable == "potato")
                        {
                            currentCalories -= 215;
                            vegetables.Dequeue();

                        }
                    }
                    else
                    {
                        isEnd = true;
                        break;
                    }
                }
                if (isEnd)
                {
                    break;
                }
                saladsMade.Add(caloriesForEachSalad.Pop());

            }

            Console.WriteLine(string.Join(" ", saladsMade));

            if (vegetables.Any())
            {
                Console.WriteLine(string.Join(" ", vegetables));
            }

            if (caloriesForEachSalad.Any())
            {
                Console.WriteLine(string.Join(" ", caloriesForEachSalad));
            }
        }
    }
}
