using System;
using System.Collections.Generic;
using System.Linq;

public class StartUp
{
    public static void Main(string[] args)
    {
        List<Box<double>> list = new List<Box<double>>();
        int timesToRead = int.Parse(Console.ReadLine());

        for (int i = 0; i < timesToRead; i++)
        {
            Box<double> box = new Box<double>();
            string input = Console.ReadLine();
            box.Add(double.Parse(input));
            list.Add(box);
        }

        double toCompareWith = double.Parse(Console.ReadLine());
        Box<double> toCompare = new Box<double>();
        toCompare.Add(toCompareWith);

        Console.WriteLine(GetBiggerElementsCount(list,toCompare));
    }

    private static int GetBiggerElementsCount<T>(List<T> list, T toCompareWith) where T : IComparable<T>
    {
        int count = 0;
        foreach (var boxes in list)
        {
            if (boxes.CompareTo(toCompareWith) == 1)
            {
                count++;
            }
            
        }
        return count;

    }
}

