using System;
using System.Collections.Generic;
using System.Linq;

namespace Lab___7._Pascal_Triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());

            long[][] triangle = new long[rows][];

            triangle[0] = new long[] { 1 };
            for (int row = 1; row < rows; row++)
            {
                triangle[row] = new long[triangle[row - 1].Length + 1];
                triangle[row][0] = 1;
                triangle[row][triangle[row].Length - 1] = 1;

                for (int col = 1; col < triangle[row].Length - 1; col++)
                {
                    triangle[row][col] = triangle[row - 1][col] + triangle[row - 1][col - 1];
                }
            }

            foreach (var array in triangle)
            {
                Console.WriteLine(string.Join(" ", array));
            }

        }
    }
}
