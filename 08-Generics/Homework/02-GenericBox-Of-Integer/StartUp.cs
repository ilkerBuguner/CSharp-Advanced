using System;


public class StartUp
{
    public static void Main(string[] args)
    {
        int timesToRead = int.Parse(Console.ReadLine());

        for (int i = 0; i < timesToRead; i++)
        {
            string input = Console.ReadLine();
            Box<int> box = new Box<int>();
            box.Add(int.Parse(input));
            Console.WriteLine(box.ToString());
        }
    }
}

