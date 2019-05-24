using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercise___07._The_V_Logger
{
    class Program
    {
        static void Main(string[] args)
        {
            var vVlogger = new Dictionary<string, KeyValuePair<HashSet<string>, HashSet<string>>>();

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "Statistics")
                {
                    break;
                }

                string[] tokens = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);

                if (tokens.Contains("joined"))
                {
                    string vloggerName = tokens[0];

                    if (!vVlogger.ContainsKey(vloggerName))
                    {
                        vVlogger[vloggerName] = new KeyValuePair<HashSet<string>, HashSet<string>>(new HashSet<string>(), new HashSet<string>());
                    }
                    else
                    {
                        continue;
                    }
                }

                if (tokens.Contains("followed"))
                {
                    string vlogger = tokens[0];
                    string otherVlogger = tokens[2];

                    if (vVlogger.ContainsKey(vlogger) && vVlogger.ContainsKey(otherVlogger) && vlogger != otherVlogger)
                    {
                        vVlogger[vlogger].Value.Add(otherVlogger);
                        vVlogger[otherVlogger].Key.Add(vlogger);
                    }
                }
            }

            Console.WriteLine($"The V-Logger has a total of {vVlogger.Count} vloggers in its logs.");

            int counter = 1;

            foreach (var vlogger in vVlogger.OrderByDescending(x => x.Value.Key.Count).ThenBy(x => x.Value.Value.Count))
            {
                Console.WriteLine($"{counter}. {vlogger.Key} : {vlogger.Value.Key.Count} followers, {vlogger.Value.Value.Count} following");
                
                if (counter == 1)
                {
                    foreach (var follower in vlogger.Value.Key.OrderBy(x => x))
                    {
                        Console.WriteLine($"*  {follower}");
                    }
                }
                counter++;
            }
        }
    }
}
