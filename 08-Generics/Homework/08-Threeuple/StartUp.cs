
using System.Collections.Generic;
using System.Linq;
using System;
using _01._Generic_Box_of_String;

public class StartUp
{
    public static void Main(string[] args)
    {
        string[] personInfo = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
        string firstName = personInfo[0];
        string lastName = personInfo[1];
        string address = personInfo[2];
        string town = personInfo[3];

        Threeuple<string, string, string> personTuple = 
            new Threeuple<string, string, string>(firstName + " " + lastName, address, town);

        string[] personBeerInfo = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
        string name = personBeerInfo[0];
        int beerLiters = int.Parse(personBeerInfo[1]);
        string drunkOrNotInfo = personBeerInfo[2];
        bool drunkOrNot = false;
        if (drunkOrNotInfo == "drunk")
        {
            drunkOrNot = true;
        }

        Threeuple<string, int, bool> personBeerTuple = 
            new Threeuple<string, int, bool>(name, beerLiters, drunkOrNot);

        string[] info = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
        string nameOf = info[0];
        double accountBalance = double.Parse(info[1]);
        string bankName = info[2];

        Threeuple<string, double, string> bankInfo = 
            new Threeuple<string, double, string>(nameOf, accountBalance, bankName);

        Console.WriteLine(personTuple.GetInfo());
        Console.WriteLine(personBeerTuple.GetInfo());
        Console.WriteLine(bankInfo.GetInfo());
    }
}

