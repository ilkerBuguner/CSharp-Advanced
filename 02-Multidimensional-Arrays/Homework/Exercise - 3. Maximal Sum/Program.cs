using System;
using System.Linq;
using System.Collections.Generic;


namespace Exercise___3._Maximal_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] matrixProps = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int rows = matrixProps[0];
            int cols = matrixProps[1];

            int[,] matrix = new int[rows, cols];
            int[,] biggestSquare = new int[3, 3];

            for (int row = 0; row < rows; row++)
            {
                int[] numbers = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = numbers[col];
                }
            }

            int biggestSum = int.MinValue;

            for (int row = 0; row < matrix.GetLength(0) - 2; row++)
            {
                for (int col = 0; col < matrix.GetLength(1) - 2; col++)
                {
                    int currentBiggestSum = matrix[row, col] + matrix[row, col + 1] + matrix[row, col + 2]
                        + matrix[row + 1, col] + matrix[row + 1, col + 1] + matrix[row + 1, col + 2]
                        + matrix[row + 2, col] + matrix[row + 2, col + 1] + matrix[row + 2, col + 2];

                    if (currentBiggestSum > biggestSum)
                    {
                        biggestSum = currentBiggestSum;

                        biggestSquare[0, 0] = matrix[row, col];
                        biggestSquare[0, 1] = matrix[row, col + 1];
                        biggestSquare[0, 2] = matrix[row, col + 2];
                        biggestSquare[1, 0] = matrix[row + 1, col];
                        biggestSquare[1, 1] = matrix[row + 1, col + 1];
                        biggestSquare[1, 2] = matrix[row + 1, col + 2];
                        biggestSquare[2, 0] = matrix[row + 2, col];
                        biggestSquare[2, 1] = matrix[row + 2, col + 1];
                        biggestSquare[2, 2] = matrix[row + 2, col + 2];
                    }
                }
            }

            Console.WriteLine($"Sum = {biggestSum}");

            for (int row = 0; row < 3; row++)
            {
                for (int col = 0; col < 3; col++)
                {
                    Console.Write(biggestSquare[row,col] + " ");
                }
                Console.WriteLine();

            }


        }
    }
}
