using System;
using System.Collections.Generic;
using System.Text;


public class CustomTuple<TItem1, TItem2>
{
    private TItem1 FirstItem;
    private TItem2 SecondItem;

    public CustomTuple(TItem1 firstItem, TItem2 secondItem)
    {
        FirstItem = firstItem;
        SecondItem = secondItem;
    }

    public string GetInfo()
    {
        return $"{FirstItem} -> {SecondItem}";
    }

}

