using System;
using System.Collections.Generic;
using System.Text;


    public class Box<T>
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

        public override string ToString()
        {
            return typeof(T) + ": " + element;
        }
    }

