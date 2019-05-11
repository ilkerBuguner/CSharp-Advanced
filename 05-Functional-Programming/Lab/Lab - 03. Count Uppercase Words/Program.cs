using System;
using System.Collections.Generic;
using System.Linq;

namespace Lab___03._Count_Uppercase_Words
{
    class Program
    {
        static void Main(string[] args)
        {
            var text = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

            Func<string, bool> func = x => char.IsUpper(x[0]);

            foreach (var item in text.Where(func))
            {
                Console.WriteLine(item);
            }


        }
    }
}
