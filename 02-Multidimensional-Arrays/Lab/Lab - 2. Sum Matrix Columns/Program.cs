using System;
using System.Collections.Generic;
using System.Linq;

namespace Lab___2._Sum_Matrix_Columns
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] info = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();

            int row = info[0];
            int col = info[1];

            int[,] matrix = new int[row, col];

            for (int i = 0; i < row; i++)
            {
                int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();

                for (int j = 0; j < array.Length; j++)
                {
                    matrix[i, j] = array[j];
                }
                
            }

            for (int i = 0; i < matrix.GetLength(1); i++)
            {
                int colSum = 0;

                for (int j = 0; j < matrix.GetLength(0); j++)
                {
                    colSum += matrix[j, i];
                }

                Console.WriteLine(colSum);
            }
        }
    }
}
