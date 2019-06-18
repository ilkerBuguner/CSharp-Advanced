using System;
using System.Collections.Generic;
using System.Linq;

namespace ListyIterator
{
    public class Program
    {
        static void Main(string[] args)
        {
            CustomStack<string> stack = new CustomStack<string>();

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "END")
                {
                    break;
                }

                if (input.Contains("Push"))
                {
                    string[] tokens = input
                        .Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries)
                        .Skip(1)
                        .ToArray();

                    stack.Push(tokens);
                }
                else if (input == "Pop")
                {
                    stack.Pop();
                }
            }

            foreach (var item in stack)
            {
                Console.WriteLine(item);
            }
        }
    }
}
