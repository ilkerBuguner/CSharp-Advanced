using System;
using System.Collections.Generic;
using System.Linq;

namespace Lab___3._Simple_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split();
            Stack<string> stack = new Stack<string>(input.Reverse());

            int result = int.Parse(stack.Pop());

            while (stack.Any())
            {
                var nextSymbol = stack.Pop();

                if (nextSymbol == "+")
                {
                    result += int.Parse(stack.Pop());

                }
                else if (nextSymbol == "-")
                {
                    result -= int.Parse(stack.Pop());
                }
            }

            Console.WriteLine(result);

        }
    }
}
