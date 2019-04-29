using System;
using System.Collections.Generic;
using System.Linq;

namespace Lab___05._Record_Unique_Names
{
    class Program
    {
        static void Main(string[] args)
        {
            int timesToRead = int.Parse(Console.ReadLine());
            HashSet<string> names = new HashSet<string>();

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
