using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercise___03._Maximum_and_Minimum_Element
{
    class Program
    {
        static void Main(string[] args)
        {
            int numOfQueries = int.Parse(Console.ReadLine());
            Stack<int> stack = new Stack<int>();
            int minNum = int.MaxValue;
            int maxNum = int.MinValue;

            for (int i = 0; i < numOfQueries; i++)
            {
                string command = Console.ReadLine();
                string[] tokens = command.Split();

                if (tokens[0] == "1")
                {
                    int numToPush = int.Parse(tokens[1]);
                    stack.Push(numToPush);
                }
                else if (command == "2")
                {
                    if (stack.Any())
                    {
                        stack.Pop();

                    }
                }
                else if (command == "3")
                {
                    Console.WriteLine(stack.Max());
                }
                else if (command == "4")
                {
                    Console.WriteLine(stack.Min());
                }
            }

            if (stack.Any())
            {

                Console.WriteLine(string.Join(", ", stack));
            }
        }
    }
}
