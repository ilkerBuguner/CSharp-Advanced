using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Excel_Functions
{
    class Program
    {
        static void Main(string[] args)
        {
            int timesToReadRow = int.Parse(Console.ReadLine());

            string[][] table = new string[timesToReadRow][];

            for (int row = 0; row < timesToReadRow; row++)
            {
                string[] col = Console.ReadLine()
                    .Split(", ", StringSplitOptions.RemoveEmptyEntries);

                table[row] = col;
            }

            string[] tokens = Console.ReadLine().Split();
            string command = tokens[0];
            string header = tokens[1];
            int headerIndex = Array.FindIndex(table[0], x => x == header);

            if (command == "hide")
            {
                for (int row = 0; row < timesToReadRow; row++)
                {
                    List<string> currentRow = new List<string>();
                    for (int col = 0; col < table[row].Length; col++)
                    {
                        currentRow.Add(table[row][col]);
                    }
                    currentRow.RemoveAt(headerIndex);
                    Console.WriteLine(string.Join(" | ", currentRow));

                }
            }
            else if (command == "sort")
            {
                string[] headerRow = table[0];
                table = table.OrderBy(x => x[headerIndex]).ToArray();
                Console.WriteLine(string.Join(" | ", headerRow));

                foreach (var row in table)
                {
                    if (row != headerRow)
                    {
                        Console.WriteLine(string.Join(" | ", row));
                    }
                }

            }
            else if (command == "filter")
            {
                string value = tokens[2];
                string[] headerRow = table[0];

                Console.WriteLine(string.Join(" | ", headerRow));
                List<string> wantedRow = new List<string>();

                for (int row = 0; row < table.Length; row++)
                {
                    if (table[row][headerIndex] == value)
                    {
                        for (int col = 0; col < table[row].Length; col++)
                        {
                            wantedRow.Add(table[row][col]);
                        }
                        Console.WriteLine(string.Join(" | ", wantedRow));
                        wantedRow = new List<string>();
                    }
                }

            }
            
        }
    }
}
