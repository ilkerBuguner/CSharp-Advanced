using System;
using System.Linq;
using System.Collections.Generic;

namespace Exercise___05._Applied_Arithmetics
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split().Select(int.Parse).ToList();


            while (true)
            {
                string command = Console.ReadLine();

                if (command == "end")
                {
                    break;
                }

                if (command == "add")
                {
                    Func<int, int> adder = x => x + 1;
                    numbers = numbers.Select(adder).ToList();
                }
                if (command == "multiply")
                {
                    Func<int, int> multiplier = x => x * 2;
                    numbers = numbers.Select(multiplier).ToList();
                }
                if (command == "subtract")
                {
                    Func<int, int> subtracter = x => x - 1;
                    numbers = numbers.Select(subtracter).ToList();
                }
                if (command == "print")
                {
                    Action<int> printNums = x => Console.Write(x + " ");
                    numbers.ToList().ForEach(printNums);
                    Console.WriteLine();
                }
            }
        }
    }
}
