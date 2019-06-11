using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercise___10._Crossroads
{
    class Program
    {
        static void Main(string[] args)
        {
            int greenLightSeconds = int.Parse(Console.ReadLine());
            int freeWindowSeconds = int.Parse(Console.ReadLine());
            Queue<string> cars = new Queue<string>();
            int passedCars = 0;
            string passingCar = string.Empty;
            int crashIndex = -1;

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "END")
                {
                    break;
                }

                if (input != "green")
                {
                    cars.Enqueue(input);
                }
                else
                {
                    int elapsedSeconds = 0;
                    while (elapsedSeconds < greenLightSeconds && cars.Any())
                    {
                        string car = cars.Peek();

                        if (car.Length + elapsedSeconds <= greenLightSeconds)
                        {
                            elapsedSeconds += car.Length;
                            passedCars++;
                            cars.Dequeue();
                        }
                        else
                        {
                            int remainingTime = car.Length + elapsedSeconds - greenLightSeconds;
                            if (remainingTime <= freeWindowSeconds)
                            {
                                passedCars++;
                                cars.Dequeue();
                                break;
                            }
                            else
                            {
                                passingCar = car;
                                crashIndex = car.Length - (remainingTime - freeWindowSeconds);
                                break;
                            }
                        }
                    }
                }

                if (passingCar != string.Empty)
                {
                    Console.WriteLine("A crash happened!");
                    Console.WriteLine($"{passingCar} was hit at {passingCar[crashIndex]}.");
                    break;
                }
            }

            if (passingCar == string.Empty)
            {
                Console.WriteLine("Everyone is safe.");
                Console.WriteLine($"{passedCars} total cars passed the crossroads.");
            }
        }
    }
}
