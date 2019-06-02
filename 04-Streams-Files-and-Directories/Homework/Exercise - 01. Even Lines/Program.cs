using System;
using System.IO;
using System.Linq;

namespace Exercise___01._Even_Lines
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var streamReader = new StreamReader(@"../../../text.txt"))
            {
                using (var streamWritter = new StreamWriter(@"../../../output.txt"))
                {
                    int counter = 0;
                    while (true)
                    {
                        string line = streamReader.ReadLine();

                        if (line == null)
                        {
                            break;
                        }

                        if (counter % 2 == 0)
                        {
                            var words = line.Split().Reverse()
                                .Select(x => x.Replace("-", "@"))
                                .Select(x => x.Replace(",", "@"))
                                .Select(x => x.Replace(".", "@"))
                                .Select(x => x.Replace("!", "@"))
                                .Select(x => x.Replace("?", "@"))
                                .ToArray();

                            streamWritter.WriteLine(string.Join(" ", words));
                        }
                        counter++;
                    }
                }
            }
        }
    }
}
