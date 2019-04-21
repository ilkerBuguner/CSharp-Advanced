using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercise___05._Fashion_Boutique
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] clothesInTheBox = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Stack<int> stackForClothes = new Stack<int>(clothesInTheBox);
            int capacity = int.Parse(Console.ReadLine());
            int racksCount = 1;
            int sumOfClothes = 0;

            while (stackForClothes.Any())
            {
                int cloth = stackForClothes.Pop();

                if (sumOfClothes + cloth < capacity)
                {
                    sumOfClothes += cloth;
                }
                else if (sumOfClothes + cloth == capacity)
                {
                    if (stackForClothes.Any())
                    {
                        racksCount++;
                        sumOfClothes = 0;
                    }
                }
                else if (sumOfClothes + cloth > capacity)
                {
                    sumOfClothes = 0;
                    racksCount++;
                    sumOfClothes += cloth;
                }
            }

            Console.WriteLine(racksCount);
        }
    }
}
