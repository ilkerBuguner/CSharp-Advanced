using System;
using System.Linq;
using System.Collections.Generic;

namespace Exercise___11._The_Party_Reservation_Filter_Module
{
    class Program
    {
        static void Main(string[] args)
        {
            var names = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            List<string> filters = new List<string>();

            while (true)
            {
                string command = Console.ReadLine();

                if (command == "Print")
                {
                    break;
                }

                string[] tokens = command.Split(";").ToArray();

                if (tokens[0] == "Add filter")
                {
                    filters.Add($"{tokens[1]} {tokens[2]}");
                }
                else if (tokens[0] == "Remove filter")
                {
                    filters.Remove($"{tokens[1]} {tokens[2]}");
                }
            }

            foreach (var filter in filters)
            {
                string[] tokens = filter.Split(" ");

                if (tokens[0] == "Starts")
                {
                    names = names.Where(x => !x.StartsWith(tokens[2])).ToList();
                }
                if (tokens[0] == "Ends")
                {
                    names = names.Where(x => !x.EndsWith(tokens[2])).ToList();
                }
                if (tokens[0] == "Length")
                {
                    names = names.Where(x => x.Length != int.Parse(tokens[1])).ToList();
                }
                if (tokens[0] == "Contains")
                {
                    names = names.Where(x => !x.Contains(tokens[1])).ToList();
                }
            }

            Console.WriteLine(string.Join(" ", names));
        }
    }
}
