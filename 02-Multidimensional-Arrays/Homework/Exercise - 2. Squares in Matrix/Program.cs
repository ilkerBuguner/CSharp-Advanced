using System;
using System.Linq;
using System.Collections.Generic;

public class Program
{
    public static void Main()
    {
        int[] sizes = Console.ReadLine().Split().Select(int.Parse).ToArray();

        char[,] matrix = new char[sizes[0], sizes[1]];
        for (int row = 0; row < sizes[0]; row++)
        {
            string[] chars = Console.ReadLine().Split().ToArray();
            for (int col = 0; col < sizes[1]; col++)
            {
                matrix[row, col] = chars[col].ToCharArray()[0];
            }
        }

        int matrixes = 0;

        for (int row = 0; row < sizes[0] - 1; row++)
        {
            for (int col = 0; col < sizes[1] - 1; col++)
            {
                if (IsMatrixFromEqualChars(row, col, matrix[row, col], matrix))
                {
                    matrixes++;
                }
            }

        }

        Console.WriteLine(matrixes);

    }

    private static bool IsMatrixFromEqualChars(int row, int col, char c, char[,] matrix)
    {
        if (matrix[row, col + 1] == c && matrix[row + 1, col] == c && matrix[row + 1, col + 1] == c)
        {
            return true;
        }

        return false;
    }
}