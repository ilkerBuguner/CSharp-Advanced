using System;
using System.Collections.Generic;
using System.Linq;

namespace Lab___05._Filter_By_Age
{
    class Program
    {

        static void Main(string[] args)
        {
            Dictionary<string, int> dict = new Dictionary<string, int>();

            int timesToRead = int.Parse(Console.ReadLine());

            for (int i = 0; i < timesToRead; i++)
            {
                string[] personInfo = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries);

                string name = personInfo[0];
                int age = int.Parse(personInfo[1]);

                dict[name] = age;
            }

            string condition = Console.ReadLine();
            int ageFilter = int.Parse(Console.ReadLine());

            string[] format = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

            Func<int, bool> filter = CreateFilter(condition, ageFilter);
            Action<KeyValuePair<string, int>> printer = CreatePrinter(format);
            ForEach(dict, filter, printer);


        }

        private static void ForEach(Dictionary<string, int> dict, Func<int, bool> filter, Action<KeyValuePair<string, int>> printer)
        {
            foreach (var kvp in dict)
            {
                if (filter(kvp.Value))
                {
                    printer(kvp);
                }
            }
        }

        public static Func<int, bool> CreateFilter(string condition, int ageFilter)
        {
            if (condition == "older")
            {
                return x => x >= ageFilter;
            }

            return x => x < ageFilter;
        }

        public static Action<KeyValuePair<string, int>> CreatePrinter(string[] format)
        {
            if (format.Length == 2)
            {
                return x => Console.WriteLine($"{x.Key} - {x.Value}");
            }

            if (format[0] == "name")
            {
                return x => Console.WriteLine($"{x.Key}");
            }

            return x => Console.WriteLine($"{x.Value}");
        }
    }
}
