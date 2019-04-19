using System;
using System.Collections.Generic;
using System.Linq;

namespace Lab___2._Stack_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            var stack = new Stack<int>(numbers);

            while (true)
            {
                string input = Console.ReadLine();
                string[] tokens = input.Split();
                string command = tokens[0].ToLower();

                if (input.ToLower() == "end")
                {
                    break;
                }

                if (command == "add")
                {
                    stack.Push(int.Parse(tokens[1]));
                    stack.Push(int.Parse(tokens[2]));
                }
                else
                {
                    int count = int.Parse(tokens[1]);
                    if (stack.Count >= count)
                    {
                        for (int i = 0; i < count; i++)
                        {
                            stack.Pop();
                        }
                    }
                }
            }

            Console.WriteLine($"Sum: {stack.Sum()}");
        }
    }
}
