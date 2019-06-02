using System;
using System.IO;
using System.Linq;

namespace Exercise___02._Line_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var streamReader = new StreamReader(@"../../../text.txt"))
            {
                using (var streamWriter = new StreamWriter(@"../../../output.txt"))
                {
                    int linesCount = 1;
                    while (true)
                    {
                        string line = streamReader.ReadLine();

                        if (line == null)
                        {
                            break;
                        }

                        int lettersCount = 0;
                        int punctuationsCount = 0;

                        for (int i = 0; i < line.Length; i++)
                        {
                            char currentChar = line[i];
                            if (char.IsLetter(currentChar))
                            {
                                lettersCount++;
                            }
                            if (char.IsPunctuation(currentChar))
                            {
                                punctuationsCount++;
                            }
                        }

                        streamWriter.WriteLine($"Line {linesCount}: {line} ({lettersCount}) ({punctuationsCount})");
                        linesCount++;

                    }

                }
            }
        }
    }
}
