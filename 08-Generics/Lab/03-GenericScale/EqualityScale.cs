using System;
using System.Collections.Generic;
using System.Text;


public class EqualityScale<T>
{
    public T Left { get; set; }
    public T Right { get; set; }

    public EqualityScale(T left, T right)
    {
        this.Left = left;
        this.Right = right;
    }

    public bool AreEqual()
    {
        return Left.Equals(Right);
    }
}

