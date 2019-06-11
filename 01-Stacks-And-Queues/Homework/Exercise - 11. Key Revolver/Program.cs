using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercise___11._Key_Revolver
{
    class Program
    {
        static void Main(string[] args)
        {
            int priceOfBullet = int.Parse(Console.ReadLine());
            int gunBarrelSize = int.Parse(Console.ReadLine());
            int[] firstNumbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] secondNumbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int valueOfIntelligence = int.Parse(Console.ReadLine());
            Stack<int> bullets = new Stack<int>(firstNumbers);
            Queue<int> locks = new Queue<int>(secondNumbers);
            int firedBullets = 0;
            int bulletsTotalCount = bullets.Count;

            while (bullets.Any() && locks.Any())
            {
                int currentBullet = bullets.Pop();
                int currentLock = locks.Peek();
                if (currentBullet <= currentLock)
                {
                    Console.WriteLine("Bang!");
                    locks.Dequeue();
                }
                else
                {
                    Console.WriteLine("Ping!");
                }
                firedBullets++;
                if (firedBullets == gunBarrelSize)
                {
                    if (bullets.Any())
                    {
                        Console.WriteLine("Reloading!");
                        firedBullets = 0;
                    }
                }
            }

            int bulletCost = (bulletsTotalCount - bullets.Count) * priceOfBullet;
            int moneyEarned = valueOfIntelligence - bulletCost;
            if (locks.Any())
            {
                Console.WriteLine($"Couldn't get through. Locks left: {locks.Count}");
            }
            else
            {
                Console.WriteLine($"{bullets.Count} bullets left. Earned ${moneyEarned}");
            }
        }
    }
}
