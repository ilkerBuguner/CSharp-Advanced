using System;
using System.Collections.Generic;
using System.Linq;

namespace Lab___8._Traffic_Jam
{
    class Program
    {
        static void Main(string[] args)
        {
            int carsPassLimit = int.Parse(Console.ReadLine());
            Queue<string> cars = new Queue<string>();
            int passedCars = 0;

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "end")
                {
                    break;
                }

                if (input == "green")
                {
                    int lowerNum = Math.Min(carsPassLimit, cars.Count);

                    for (int i = 0; i < lowerNum; i++)
                    {
                        Console.WriteLine($"{cars.Dequeue()} passed!");
                        passedCars++;
                    }
                }
                else
                {
                    cars.Enqueue(input);
                }
            }

            Console.WriteLine($"{passedCars} cars passed the crossroads.");
        }
    }
}
