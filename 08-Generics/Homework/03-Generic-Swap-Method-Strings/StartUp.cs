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

        int[] indexOfElements = Console.ReadLine().Split().Select(int.Parse).ToArray();

        Swap(list, indexOfElements[0], indexOfElements[1]);

        foreach (var element in list)
        {
            Console.WriteLine(element.ToString());
        }
    }

    private static void Swap<T>(List<T> list, int firstIndex, int secondIndex)
    {
        T temp = list[firstIndex];
        list[firstIndex] = list[secondIndex];
        list[secondIndex] = temp;

    }
}

