using System;
using System.Linq;
using System.Collections.Generic;

namespace Exercise___10._Predicate_Party_
{
    class Program
    {
        static void Main(string[] args)
        {
            var names = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries).ToList();

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "Party!")
                {
                    break;
                }

                string[] tokens = input.Split();
                string command = tokens[0];

                Func<string, bool> filter = CreateFilter(tokens);

                if (command == "Remove")
                {
                    for (int i = 0; i < names.Count; i++)
                    {
                        if (filter(names[i]))
                        {
                            names.RemoveAt(i);
                            i--;
                        }
                    }
                }
                if (command == "Double")
                {
                    for (int i = 0; i < names.Count; i++)
                    {
                        if (filter(names[i]))
                        {
                            names.Insert(i, names[i]);
                            i++;
                        }
                    }
                }


            }

            if (names.Any())
            {
                Console.WriteLine($"{string.Join(", ", names)} are going to the party!");
            }
            else
            {
                Console.WriteLine("Nobody is going to the party!");
            }
        }

        public static Func<string, bool> CreateFilter(string[] tokens)
        {
            if (tokens[1] == "StartsWith")
            {
                return x => x.StartsWith(tokens[2]);
            }

            if (tokens[1] == "EndsWith")
            {
                return x => x.EndsWith(tokens[2]);
            }

            return x => x.Length == int.Parse(tokens[2]);
        }
    }
}
