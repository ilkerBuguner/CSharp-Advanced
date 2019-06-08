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
            int carsNum = int.Parse(Console.ReadLine());
            List<Car> carsList = new List<Car>();

            for (int i = 0; i < carsNum; i++)
            {
                var carsInfo = Console.ReadLine().Split();

                string model = carsInfo[0];
                int engineSpeed = int.Parse(carsInfo[1]);
                int enginePower = int.Parse(carsInfo[2]);

                Engine engine = new Engine(engineSpeed, enginePower);

                int cargoWeight = int.Parse(carsInfo[3]);
                string cargoType = carsInfo[4];

                Cargo cargo = new Cargo(cargoWeight, cargoType);
                Tire[] tires = new Tire[4]
                {
                    new Tire(){Pressure = double.Parse(carsInfo[5]), Age = int.Parse(carsInfo[6])},
                    new Tire(){Pressure = double.Parse(carsInfo[7]), Age = int.Parse(carsInfo[8])},
                    new Tire(){Pressure = double.Parse(carsInfo[9]), Age = int.Parse(carsInfo[10])},
                    new Tire(){Pressure = double.Parse(carsInfo[11]), Age = int.Parse(carsInfo[12])}
                };

                Car newCar = new Car(model, engine, cargo, tires);

                carsList.Add(newCar);

            }

            string command = Console.ReadLine();

            if (command == "fragile")
            {
                foreach (var car in carsList)
                {
                    if (car.Cargo.Type == "fragile" && car.Tires.Any(x => x.Pressure < 1))
                    {
                        Console.WriteLine(car.Model);
                    }
                }
            }
            else if (command == "flamable")
            {
                foreach (var car in carsList)
                {
                    if (car.Cargo.Type == "flamable" && car.Engine.Power > 250)
                    {
                        Console.WriteLine(car.Model);
                    }
                }
            }
        }
    }
}
