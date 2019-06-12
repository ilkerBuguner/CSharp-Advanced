using System;
using System.Collections.Generic;
using System.Linq;

public class StartUp
{
    public static void Main(string[] args)
    {
        List<Box<string>> list = new List<Box<string>>();
        int timesToRead = int.Parse(Console.ReadLine());

        for (int i = 0; i < timesToRead; i++)
        {
            Box<string> box = new Box<string>();
            string input = Console.ReadLine();
            box.Add(input);
            list.Add(box);
        }

        string toCompareWith = Console.ReadLine();
        Box<string> toCompare = new Box<string>();
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

