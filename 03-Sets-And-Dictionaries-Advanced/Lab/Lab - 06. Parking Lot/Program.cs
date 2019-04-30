using System;
using System.Collections.Generic;
using System.Linq;

namespace Lab___06._Parking_Lot
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> parking = new HashSet<string>();

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "END")
                {
                    break;
                }

                string[] command = input.Split(", ");

                string direction = command[0];
                string carNum = command[1];

                if (direction == "IN")
                {
                    parking.Add(carNum);
                }
                else if (direction == "OUT")
                {
                    parking.Remove(carNum);
                }
            }

            if (parking.Count == 0)
            {
                Console.WriteLine("Parking Lot is Empty");
            }
            else
            {
                foreach (var car in parking)
                {
                    Console.WriteLine(car);
                }
            }
        }
    }
}
