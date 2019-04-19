using System;
using System.Collections.Generic;
using System.Linq;

namespace Lab___4._Matching_Brackets
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Stack<int> stack = new Stack<int>();

            for (int i = 0; i < input.Length; i++)
            {
                char currentChar = input[i];
                if (currentChar == '(')
                {
                    stack.Push(i);
                }
                else if (currentChar == ')')
                {
                    int indexToStart = stack.Pop();
                    string subExpression = input.Substring(indexToStart, i - indexToStart + 1);
                    Console.WriteLine(subExpression);
                }
            }
        }
    }
}
