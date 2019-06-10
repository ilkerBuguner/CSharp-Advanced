using System;
using System.Collections.Generic;

namespace Workshop__Custom_Doubly_Linked_List_
{
    class Program
    {
        static void Main(string[] args)
        {
            DoublyLinkedList list = new DoublyLinkedList();

            list.AddFirst(3);
            list.AddFirst(2);
            list.AddFirst(1);
            list.AddFirst(1);
            list.AddLast(4);
            list.RemoveLast();
            list.RemoveFirst();


            list.ForEach(Console.WriteLine);
            var arr = list.ToArray();
            Console.WriteLine(string.Join(", ", arr));
        }
    }
}
