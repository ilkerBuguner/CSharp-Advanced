using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercise___08._Ranking
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> contestInfo = new Dictionary<string, string>();
            var ranking = new Dictionary<string, Dictionary<string, int>>();

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "end of contests")
                {
                    break;
                }

                string[] tokens = input.Split(':');

                string contest = tokens[0];
                string contestPass = tokens[1];

                contestInfo.Add(contest, contestPass);
            }

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "end of submissions")
                {
                    break;
                }

                string[] tokens = input.Split("=>");

                string contestName = tokens[0];
                string contestPass = tokens[1];
                string username = tokens[2];
                int points = int.Parse(tokens[3]);

                if (contestInfo.ContainsKey(contestName))
                {
                    if (contestInfo[contestName] == contestPass)
                    {
                        if (!ranking.ContainsKey(username))
                        {
                            ranking[username] = new Dictionary<string, int>();
                            ranking[username][contestName] = points;
                        }
                        else
                        {
                            if (!ranking[username].ContainsKey(contestName))
                            {
                                ranking[username][contestName] = points;
                            }
                            else
                            {
                                if (points > ranking[username][contestName])
                                {
                                    ranking[username][contestName] = points;
                                }
                            }
                            
                        }

                    }
                }
            }

            string bestUsername = string.Empty;
            int maxSum = 0;

            foreach (var username in ranking)
            {
                int currentMaxSum = 0;
                foreach (var contest in ranking[username.Key])
                {
                    currentMaxSum += contest.Value;
                }

                if (currentMaxSum > maxSum)
                {
                    maxSum = currentMaxSum;
                    bestUsername = username.Key;
                }
            }

            Console.WriteLine($"Best candidate is {bestUsername} with total {maxSum} points.");
            Console.WriteLine($"Ranking:");

            foreach (var username in ranking.OrderBy(x => x.Key))
            {
                Console.WriteLine($"{username.Key}");
                foreach (var contest in ranking[username.Key].OrderByDescending(x => x.Value))
                {
                    Console.WriteLine($"#  {contest.Key} -> {contest.Value}");
                }
            }

        }
    }
}
