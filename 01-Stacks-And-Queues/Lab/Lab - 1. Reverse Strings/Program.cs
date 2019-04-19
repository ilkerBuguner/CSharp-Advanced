using System;
using System.Collections.Generic;
using System.Linq;

namespace Lab___1._Reverse_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string words = Console.ReadLine();
            var wordsAsStack = new Stack<char>();

            foreach (var ch in words)
            {
                wordsAsStack.Push(ch);
            }

            while (wordsAsStack.Any())
            {
                Console.Write(wordsAsStack.Pop());
            }
            
        }
    }
}
