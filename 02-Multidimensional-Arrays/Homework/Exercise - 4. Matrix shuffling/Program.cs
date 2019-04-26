using System;
using System.Linq;
using System.Collections.Generic;

namespace Exercise___4._Matrix_shuffling
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] matrixSize = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            int rows = matrixSize[0];
            int cols = matrixSize[1];

            string[,] matrix = new string[rows, cols];

            for (int row = 0; row < rows; row++)
            {
                string[] numbers = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();

                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = numbers[col];
                }
            }

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "END")
                {
                    break;
                }

                string[] inputAsArray = input.Split().ToArray();

                if (inputAsArray.Length != 5 || inputAsArray[0] != "swap")
                {
                    Console.WriteLine("Invalid input!");
                    continue;
                }
                else
                {
                    int row1 = int.Parse(inputAsArray[1]);
                    int col1 = int.Parse(inputAsArray[2]);
                    int row2 = int.Parse(inputAsArray[3]);
                    int col2 = int.Parse(inputAsArray[4]);

                    if (matrix.GetLength(0) < row1 
                        || matrix.GetLength(0) < row2 
                        || matrix.GetLength(1) < col1 
                        || matrix.GetLength(1) < col2)
                    {
                        Console.WriteLine("Invalid input!");
                        continue;
                    }

                    string reservedNum = matrix[row1, col1];

                    matrix[row1, col1] = matrix[row2, col2];
                    matrix[row2, col2] = reservedNum;

                    for (int row = 0; row < rows; row++)
                    {
                        for (int col = 0; col < cols; col++)
                        {
                            Console.Write(matrix[row,col] + " ");
                        }
                        Console.WriteLine();
                    }
                }
            }
        }
    }
}
