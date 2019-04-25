using System;
using System.Collections.Generic;
using System.Linq;

namespace Lab___6._Jagged_Array_Modification
{
    class Program
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());

            int[][] jaggedArray = new int[rows][];

            for (int i = 0; i < rows; i++)
            {
                var numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

                jaggedArray[i] = numbers;
            }

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "END")
                {
                    break;
                }

                string[] inputInfo = input.Split();

                string command = inputInfo[0];
                int row = int.Parse(inputInfo[1]);
                int col = int.Parse(inputInfo[2]);
                int value = int.Parse(inputInfo[3]);

                if (row > rows || row < 0)
                {
                    Console.WriteLine("Invalid coordinates");
                    continue;
                }
                if (col > rows || col < 0)
                {
                    Console.WriteLine("Invalid coordinates");
                    continue;
                }

                if (command == "Add")
                {
                    jaggedArray[row][col] += value;
                }
                else if (command == "Subtract")
                {
                    jaggedArray[row][col] -= value;
                }

            }

            foreach (var array in jaggedArray)
            {
                Console.WriteLine(string.Join(" ", array));
            }

        }
    }
}
