using System;
using System.Collections.Generic;
using System.Text;

namespace BoxOfT
{
    public class Box<T>
    {
        private Stack<T> list;
        public Box()
        {
            list = new Stack<T>();
        }
        public int Count
        {
            get => list.Count;
        }
        public void Add(T element)
        {
            list.Push(element);
        }

        public T Remove()
        {
            T element = list.Pop();

            return element;
        }

    }
}
