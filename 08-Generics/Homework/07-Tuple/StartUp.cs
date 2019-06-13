
using System.Collections.Generic;
using System.Linq;
using System;

public class StartUp
{
    public static void Main(string[] args)
    {
        string[] personInfo = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
        string firstName = personInfo[0];
        string lastName = personInfo[1];
        string address = personInfo[2];

        CustomTuple<string, string> personTuple = 
            new CustomTuple<string, string>(firstName + " " + lastName, address);

        string[] personBeerInfo = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
        string name = personBeerInfo[0];
        int beerLiters = int.Parse(personBeerInfo[1]);

        CustomTuple<string, int> personBeerTuple = 
            new CustomTuple<string, int>(name, beerLiters);

        string[] info = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
        int myInteger = int.Parse(info[0]);
        double myDouble = double.Parse(info[1]);

        CustomTuple<int, double> numbersTuple = 
            new CustomTuple<int, double>(myInteger, myDouble);

        Console.WriteLine(personTuple.GetInfo());
        Console.WriteLine(personBeerTuple.GetInfo());
        Console.WriteLine(numbersTuple.GetInfo());
    }
}

