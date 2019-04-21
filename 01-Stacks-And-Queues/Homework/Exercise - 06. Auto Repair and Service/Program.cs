using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercise___06._Auto_Repair_and_Service
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<string> carsOnService = new Queue<string>(Console.ReadLine().Split());
            Stack<string> servedCars = new Stack<string>();

            while (true)
            {
                string command = Console.ReadLine();


                if (command == "End")
                {
                    break;
                }

                if (command == "Service")
                {
                    if (carsOnService.Any())
                    {
                        string car = carsOnService.Dequeue();
                        servedCars.Push(car);
                        Console.WriteLine($"Vehicle {car} got served.");
                    }
                }
                
                if (command.Contains("CarInfo-"))
                {
                    string carModel = command.Split("-").ToArray()[1];
                    if (carsOnService.Contains(carModel))
                    {
                        Console.WriteLine("Still waiting for service.");
                    }
                    else
                    {
                        Console.WriteLine("Served.");
                    }
                }

                if (command == "History")
                {
                    Console.WriteLine(string.Join(", ", servedCars));
                }
            }

            if (carsOnService.Any())
            {
                Console.WriteLine($"Vehicles for service: {string.Join(", ", carsOnService)}");
            }

            Console.WriteLine($"Served vehicles: {string.Join(", ", servedCars)}");

        }
    }
}
