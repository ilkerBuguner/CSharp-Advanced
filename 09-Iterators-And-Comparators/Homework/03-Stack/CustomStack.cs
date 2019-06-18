using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace ListyIterator
{
    public class CustomStack<T> : IEnumerable<T>
    {
        private List<T> items;

        public CustomStack()
        {
            items = new List<T>();
        }

        public void Push(params T[] items)
        {
            foreach (var item in items)
            {
                this.items.Add(item);
            }
        }

        public void Pop()
        {
            if (items.Count == 0)
            {
                Console.WriteLine("No elements");
            }
            else
            {
                this.items.RemoveAt(items.Count - 1);
            }
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = items.Count - 1; i >= 0; i--)
            {
                yield return items[i];
            }

            for (int i = items.Count - 1; i >= 0; i--)
            {
                yield return items[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
