using System;
using System.Collections.Generic;
using System.Linq;


namespace Exercise___01._Unique_Usernames
{
    class Program
    {
        static void Main(string[] args)
        {
            int timesToRead = int.Parse(Console.ReadLine());
            var names = new HashSet<string>();

            for (int i = 0; i < timesToRead; i++)
            {
                string name = Console.ReadLine();

                names.Add(name);
            }

            foreach (var name in names)
            {
                Console.WriteLine(name);
            }
        }
    }
}
