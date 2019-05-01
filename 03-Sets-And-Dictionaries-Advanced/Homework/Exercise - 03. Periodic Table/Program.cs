using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercise___03._Periodic_Table
{
    class Program
    {
        static void Main(string[] args)
        {
            var elements = new HashSet<string>();

            int timesToRead = int.Parse(Console.ReadLine());

            for (int i = 0; i < timesToRead; i++)
            {
                string[] currentElements = Console.ReadLine().Split();

                for (int j = 0; j < currentElements.Length; j++)
                {
                    string currentElement = currentElements[j];
                    elements.Add(currentElement);
                }
            }

            Console.WriteLine(string.Join(" ", elements.OrderBy(x => x)));
        }
    }
}
