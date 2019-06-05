using System;
using System.Collections.Generic;
using System.Linq;

namespace DefiningClasses
{
    public class StartUp
    {
        public static void Main()
        {
            int timesToRead = int.Parse(Console.ReadLine());
            Family family = new Family();
            List<Person> listOfOldPeople = new List<Person>();

            for (int i = 0; i < timesToRead; i++)
            {
                string[] input = Console.ReadLine().Split();
                string name = input[0];
                int age = int.Parse(input[1]);

                Person newFamilyMember = new Person(name, age);
                family.AddMember(newFamilyMember);
            }

            foreach (var member in family.People)
            {
                if (member.Age > 30)
                {
                    listOfOldPeople.Add(member);
                }
            }

            foreach (var member in listOfOldPeople.OrderBy(x => x.Name))
            {
                Console.WriteLine($"{member.Name} - {member.Age}");
            }
        }
    }
}
