using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exercise___09._Simple_Text_Editor
{
    class Program
    {
        static void Main(string[] args)
        {
            int timesToManipulate = int.Parse(Console.ReadLine());
            Stack<string> history = new Stack<string>();
            string text = string.Empty;

            for (int i = 0; i < timesToManipulate; i++)
            {
                var commands = Console.ReadLine().Split().ToArray();

                if (commands[0] == "1")
                {
                    history.Push(text);
                    StringBuilder sb = new StringBuilder(text);
                    sb.Append(commands[1]);
                    text = sb.ToString();
                }
                else if (commands[0] == "2")
                {
                    int count = int.Parse(commands[1]);

                    history.Push(text);
                    text = text.Remove(text.Length - count);
                }
                else if (commands[0] == "3")
                {
                    int index = int.Parse(commands[1]);
                    Console.WriteLine(text[index - 1]);
                }
                else if (commands[0] == "4")
                {
                    text = history.Pop();
                }
                    
            }
        }
    }
}
