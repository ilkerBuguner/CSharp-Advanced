using DefiningClasses;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem_6._Speed_Racing__Defining_Classes_Exercise_
{
    class StartUp
    {
        static void Main(string[] args)
        {
            int timesToReadEngineInfo = int.Parse(Console.ReadLine());
            List<Engine> listOfEngines = new List<Engine>();
            List<Car> listOfCars = new List<Car>();

            for (int i = 0; i < timesToReadEngineInfo; i++)
            {
                string[] engineInfo = Console.ReadLine().Split();

                string model = engineInfo[0];
                string power = engineInfo[1];

                if (engineInfo.Length == 2)
                {
                    listOfEngines.Add(new Engine(model, power));
                }
                else if (engineInfo.Length == 3)
                {
                    if (Char.IsDigit(engineInfo[2][0]))
                    {
                        listOfEngines.Add(new Engine(model, power, engineInfo[2]));
                    }
                    else
                    {
                        listOfEngines.Add(new Engine(model, power, "n/a", engineInfo[2]));
                    }
                }
                else if (engineInfo.Length == 4)
                {
                    listOfEngines.Add(new Engine(model, power, engineInfo[2], engineInfo[3]));
                }
            }

            int timesToReadCarInfo = int.Parse(Console.ReadLine());

            for (int i = 0; i < timesToReadCarInfo; i++)
            {
                var carInfo = Console.ReadLine().Split();

                string model = carInfo[0];
                Engine engine = listOfEngines.FirstOrDefault(x => x.Model == carInfo[1]);

                if (carInfo.Length == 2)
                {
                    listOfCars.Add(new Car(model, engine));
                }
                else if (carInfo.Length == 3)
                {
                    if (Char.IsDigit(carInfo[2][0]))
                    {
                        listOfCars.Add(new Car(model, engine, carInfo[2]));
                    }
                    else
                    {
                        listOfCars.Add(new Car(model, engine, "n/a", carInfo[2]));
                    }
                }
                else if(carInfo.Length == 4)
                {
                    listOfCars.Add(new Car(model, engine, carInfo[2], carInfo[3]));
                }
            }

            foreach (var car in listOfCars)
            {
                Console.WriteLine($"{car.Model}:");
                Console.WriteLine($"  {car.Engine.Model}:");
                Console.WriteLine($"    Power: {car.Engine.Power}");
                Console.WriteLine($"    Displacement: {car.Engine.Displacement}");
                Console.WriteLine($"    Efficiency: {car.Engine.Efficiency}");
                Console.WriteLine($"  Weight: {car.Weight}");
                Console.WriteLine($"  Color: {car.Color}");
            }
        }
    }
}
