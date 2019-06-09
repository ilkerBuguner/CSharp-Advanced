using System;
using System.Collections.Generic;
using System.Text;

namespace Workshop__Custom_List_and_Stack_
{
    class CustomStack
    {
        private const int initialCapacity = 4;
        private int[] items;
        private int count;

        public CustomStack()
        {
            count = 0;
            items = new int[initialCapacity];
        }

        public int Count
        {
            get
            {
                return count;
            }
        }

        private void Resize()
        {
            int[] tempArr = new int[items.Length * 2];
            items.CopyTo(tempArr, 0);
            items = tempArr;
        }
        public void Push(int element)
        {
            if (count == items.Length)
            {
                Resize();
            }

            items[count] = element;
            count++;
        }

        public int Pop()
        {
            if (Count == 0)
            {
                throw new InvalidOperationException("Custom stack is empty");
            }

            var itemToPop = items[Count - 1];
            items[Count - 1] = 0;
            count--;
            return itemToPop;
        }

        public int Peek()
        {
            if (Count == 0)
            {
                throw new InvalidOperationException("Custom stack is empty");
            }

            return items[Count];
        }

        public void ForEach(Action<int> action)
        {
            for (int i = 0; i < count; i++)
            {
                action(items[i]);
            }
        }
    }
}
