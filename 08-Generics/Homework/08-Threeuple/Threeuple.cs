using System;
using System.Collections.Generic;
using System.Text;

namespace _01._Generic_Box_of_String
{
    public class Threeuple<TItem1,TItem2,TItem3>
    {
        private TItem1 FirstItem;
        private TItem2 SecondItem;
        private TItem3 ThirdItem;

        public Threeuple(TItem1 firstItem, TItem2 secondItem, TItem3 thirdItem)
        {
            FirstItem = firstItem;
            SecondItem = secondItem;
            ThirdItem = thirdItem;
        }

        public string GetInfo()
        {
            return $"{FirstItem} -> {SecondItem} -> {ThirdItem}";
        }
    }
}
