using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercise___1._Diagonal_Difference
{
    class Program
    {
        static void Main(string[] args)
        {
            int matrixSize = int.Parse(Console.ReadLine());

            int[,] matrix = new int[matrixSize, matrixSize];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = numbers[col];
                }
            }

            int firstDiagonalSum = 0;
            int secondDiagonalSum = 0;

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    if (row == col)
                    {
                        firstDiagonalSum += matrix[row, col];
                    }

                    if (col == matrix.GetLength(1) - row - 1)
                    {
                        secondDiagonalSum += matrix[row, col];
                    }
                }
            }


            Console.WriteLine(Math.Abs(firstDiagonalSum - secondDiagonalSum));
        }
    }
}
