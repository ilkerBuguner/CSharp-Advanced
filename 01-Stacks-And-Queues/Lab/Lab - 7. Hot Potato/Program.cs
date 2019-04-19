using System;
using System.Collections.Generic;
using System.Linq;

namespace Lab___7._Hot_Potato
{
    class Program
    {
        static void Main(string[] args)
        {
            var kids = Console.ReadLine().Split().ToArray();
            int potato = int.Parse(Console.ReadLine());
            Queue<string> queue = new Queue<string>(kids);
            int counter = 1;

            while (queue.Count > 1)
            {
                string removedKid = queue.Dequeue();

                if (counter % potato != 0)
                {
                    queue.Enqueue(removedKid);
                }
                else
                {
                    Console.WriteLine($"Removed {removedKid}");
                }
                counter++;
            }

            Console.WriteLine($"Last is {queue.Dequeue()}");
        }
    }
}
