using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Workshop__Custom_List_and_Stack_
{
    class CustomList
    {
        private int[] items;
        private const int InitialCapacity = 2;
        public int Count { get; private set; }

        public CustomList()
        {
            items = new int[InitialCapacity];
        }

        public int this[int index]
        {
            get
            {
                if (index >= Count)
                {
                    throw new ArgumentOutOfRangeException();
                }
                return items[index];
            }
            set
            {
                if (index >= Count)
                {
                    throw new ArgumentOutOfRangeException();
                }
                items[index] = value;
            }
        }

        private void Resize()
        {
            int[] tempArr = new int[items.Length * 2];

            items.CopyTo(tempArr, 0);
            items = tempArr;
        }

        private void ShiftToLeft(int index)
        {
            for (int i = index; i < Count - 1; i++)
            {
                items[i] = items[i + 1];
            }
        }

        private void ShoftToRight(int index)
        {
            for (int i = Count; i > index; i--)
            {
                items[i] = items[i - 1];
            }
        }

        private void Shrink()
        {
            int[] tempArr = new int[items.Length / 2];
            for (int i = 0; i < Count; i++)
            {
                tempArr[i] = items[i];
            }
            items = tempArr;
        }

        public void Add(int item)
        {
            if (Count == items.Length)
            {
                Resize();
            }
            items[Count] = item;
            Count++;
        }


        public int RemoveAt(int index)
        {
            if (index >= Count)
            {
                throw new ArgumentOutOfRangeException();
            }

            var item = items[index];
            items[index] = default(int);
            ShiftToLeft(index);
            Count--;

            if (Count <= items.Length/4)
            {
                Shrink();
            }

            return item;

        }

        public void Insert(int index, int element)
        {
            if (index > Count)
            {
                throw new IndexOutOfRangeException();
            }
            if (Count == items.Length)
            {
                Resize();
            }

            ShoftToRight(index);

            items[index] = element;
            Count++;
        }

        public bool Contains(int element)
        {
            if (items.Contains(element))
            {
                return true;
            }
            return false;
        }

        public void Swap(int firstIndex, int secondIndex)
        {
            if (firstIndex > Count - 1 || secondIndex > Count - 1)
            {
                throw new IndexOutOfRangeException();
            }

            int tempNum = items[firstIndex];
            items[firstIndex] = items[secondIndex];
            items[secondIndex] = tempNum;
        }
    }
}
