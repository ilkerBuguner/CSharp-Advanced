using System;
using System.Collections.Generic;
using System.Linq;

namespace Lab___04._Cities_by_Continent_and_Country
{
    class Program
    {
        static void Main(string[] args)
        {
            int timesToRead = int.Parse(Console.ReadLine());

            var dict = new Dictionary<string, Dictionary<string, List<string>>>();

            for (int i = 0; i < timesToRead; i++)
            {
                string[] info = Console.ReadLine().Split();

                string continent = info[0];
                string country = info[1];
                string city = info[2];

                if (!dict.ContainsKey(continent))
                {
                    dict[continent] = new Dictionary<string, List<string>>();
                }

                if (!dict[continent].ContainsKey(country))
                {
                    dict[continent][country] = new List<string>();
                }

                dict[continent][country].Add(city);
            }

            foreach (var continent in dict)
            {
                Console.WriteLine($"{continent.Key}:");

                foreach (var country in continent.Value)
                {
                    Console.WriteLine($"  {country.Key} -> {string.Join(", ", country.Value)}");
                }
            }
        }
    }
}
