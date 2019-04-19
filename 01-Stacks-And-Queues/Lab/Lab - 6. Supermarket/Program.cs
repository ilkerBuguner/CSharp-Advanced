using System;
using System.Collections.Generic;
using System.Linq;

namespace Lab___6._Supermarket
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<string> customers = new Queue<string>();
            while (true)
            {
                string input = Console.ReadLine();

                if (input == "End")
                {
                    break;
                }

                if (input == "Paid")
                {
                    while (customers.Any())
                    {
                        Console.WriteLine(customers.Dequeue());
                    }
                }
                else
                {
                    customers.Enqueue(input);
                }
            }


            Console.WriteLine($"{customers.Count} people remaining.");

        }
    }
}
