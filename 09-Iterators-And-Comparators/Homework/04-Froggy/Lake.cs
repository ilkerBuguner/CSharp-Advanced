using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace ListyIterator
{
    class Lake : IEnumerable<int>
    {
        private List<int> stones;

        public Lake(params int[] nums)
        {
            stones = new List<int>(nums);
        }
        
        public IEnumerator<int> GetEnumerator()
        {
            List<int> oddPositions = new List<int>();
            List<int> evenPositions = new List<int>();
            List<int> allPositions = new List<int>();

            for (int i = 0; i < stones.Count; i++)
            {
                if (i % 2 == 0)
                {
                    evenPositions.Add(stones[i]);
                }
                else
                {
                    oddPositions.Add(stones[i]);
                }
            }

            foreach (var stone in evenPositions)
            {
                yield return stone;
            }

            oddPositions.Reverse();

            foreach (var stone in oddPositions)
            {
                yield return stone;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
