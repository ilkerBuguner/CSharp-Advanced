using System;
using System.Collections.Generic;
using System.Linq;

namespace ListyIterator
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<Person> people = new List<Person>();

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "END")
                {
                    break;
                }

                string[] tokens = input.Split();
                string name = tokens[0];
                int age = int.Parse(tokens[1]);
                string town = tokens[2];

                Person newPerson = new Person(name, age, town);
                people.Add(newPerson);
            }

            int personNumber = int.Parse(Console.ReadLine());

            int equalPeople = 0;
            int notEqualPeople = 0;

            Person personToCompare = people[personNumber - 1];

            foreach (var person in people)
            {
                int compare = personToCompare.CompareTo(person);
                if (compare == 0)
                {
                    equalPeople++;
                }
                else
                {
                    notEqualPeople++;
                }
            }

            if (equalPeople == 1)
            {
                Console.WriteLine("No matches");
            }
            else
            {
                Console.WriteLine($"{equalPeople} {notEqualPeople} {people.Count}");
            }

        }
    }
}
