using System;
using System.Collections.Generic;
using System.Text;


public class Box<T> : IComparable<Box<T>> where T : IComparable<T>
{
    private T element;

    public Box()
    {
        element = default(T);
    }

    public void Add(T element)
    {
        this.element = element;
    }

    public int CompareTo(Box<T> other)
    {
        return element.CompareTo(other.element);
    }


    public override string ToString()
    {
        return typeof(T) + ": " + element;
    }
}

