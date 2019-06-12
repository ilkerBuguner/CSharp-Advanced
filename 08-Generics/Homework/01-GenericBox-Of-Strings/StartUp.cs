using System;


public class Program
{
    public static void Main(string[] args)
    {
        int timesToRead = int.Parse(Console.ReadLine());

        for (int i = 0; i < timesToRead; i++)
        {
            string input = Console.ReadLine();
            Box<string> box = new Box<string>();
            box.Add(input);
            Console.WriteLine(box);
        }
    }
}

