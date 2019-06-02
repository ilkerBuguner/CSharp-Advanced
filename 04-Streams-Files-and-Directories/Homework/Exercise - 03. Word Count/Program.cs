using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;

namespace Exercise___03._Word_Count
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> dict = new Dictionary<string, int>();

            using (var readerFromWordsFile = new StreamReader(@"../../../words.txt"))
            {
                while (true)
                {
                    string line = readerFromWordsFile.ReadLine();

                    if (line == null)
                    {
                        break;
                    }

                    dict[line] = 0;
                }

            }

            using (var readerFromTextFile = new StreamReader(@"../../../text.txt"))
            {
                using (var streamWriter = new StreamWriter(@"../../../actualResults.txt"))
                {
                    while (true)
                    {
                        string lineFromTextFile = readerFromTextFile.ReadLine();

                        if (lineFromTextFile == null)
                        {
                            break;
                        }

                        string[] lineToLower = lineFromTextFile.Split()
                            .Select(x => x.TrimStart(new[] { '-', ',', '.', '?', '!' }))
                            .Select(x => x.TrimEnd(new[] { '-', ',', '.', '?', '!' }))
                            .Select(x => x.ToLower()).ToArray();


                        foreach (var word in lineToLower)
                        {
                            if (dict.ContainsKey(word))
                            {
                                dict[word]++;
                            }
                        }

                    }

                    foreach (var word in dict.OrderByDescending(x => x.Value))
                    {
                        streamWriter.WriteLine($"{word.Key} - {word.Value}");
                    }

                }
            }

        }
    }
}
