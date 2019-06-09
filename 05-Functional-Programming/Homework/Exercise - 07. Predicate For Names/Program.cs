using System;
using System.Linq;
using System.Collections.Generic;

namespace Exercise___07._Predicate_For_Names
{
    class Program
    {
        static void Main(string[] args)
        {
            int namesLength = int.Parse(Console.ReadLine());
            Func<string, bool> func = x => x.Length <= namesLength;
            var names = Console.ReadLine().Split().Where(func).ToList();

            foreach (var name in names)
            {
                Console.WriteLine(name);
            }
        }
    }
}
