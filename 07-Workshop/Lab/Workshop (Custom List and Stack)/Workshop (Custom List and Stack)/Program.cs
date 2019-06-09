using System;

namespace Workshop__Custom_List_and_Stack_
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomStack stack = new CustomStack();

            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            stack.Push(4);

            stack.ForEach(Console.WriteLine);

        }
    }
}
