﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ListyIterator
{
    public class Person : IComparable<Person>
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Town { get; set; }

        public Person(string name, int age, string town)
        {
            Name = name;
            Age = age;
            Town = town;
        }
        public int CompareTo(Person other)
        {
            int compare = Name.CompareTo(other.Name);
            if (compare == 0)
            {
                compare = Age.CompareTo(other.Age);

                if (compare == 0)
                {
                    compare = Town.CompareTo(other.Town);
                }
            }
            return compare;
        }
    }
}
