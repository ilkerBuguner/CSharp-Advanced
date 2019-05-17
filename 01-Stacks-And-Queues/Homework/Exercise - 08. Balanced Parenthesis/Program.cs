using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercise___08._Balanced_Parenthesis
{
    class Program
    {
        static void Main(string[] args)
        {
            string line = Console.ReadLine();
            Stack<char> stack = new Stack<char>();

            for (int i = 0; i < line.Length; i++)
            {
                char currentChar = line[i];

                if (line[i] == '{')
                {
                    stack.Push(line[i]);
                }

                if (line[i] == '[')
                {
                    stack.Push(line[i]);
                }

                if (line[i] == '(')
                {
                    stack.Push(line[i]);
                }


                if (currentChar == ')')
                {
                    if (stack.Any() && stack.Peek() == '(')
                    {
                        stack.Pop();

                    }
                    else
                    {
                        Console.WriteLine("NO");
                        return;
                    }
                }
                if (currentChar == ']')
                {
                    if (stack.Any() && stack.Peek() == '[')
                    {
                        stack.Pop();

                    }
                    else
                    {
                        Console.WriteLine("NO");
                        return;
                    }
                }
                if (currentChar == '}')
                {
                    if (stack.Any() && stack.Peek() == '{')
                    {
                        stack.Pop();


                    }
                    else
                    {
                        Console.WriteLine("NO");
                        return;
                    }
                }
            }

            if (stack.Any())
            {
                Console.WriteLine("NO");
            }
            else
            {
                Console.WriteLine("YES");
            }
        }
    }
}
