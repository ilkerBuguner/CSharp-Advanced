using System;
using System.Linq;
using System.Collections.Generic;

namespace Helen_s_Abduction__Multidimention_Arrays_
{
    class Program
    {
        public static int parisRow = 0;
        public static int parisCol = 0;

        static void Main(string[] args)
        {
            int energy = int.Parse(Console.ReadLine());
            int fieldSize = int.Parse(Console.ReadLine());

            char[][] field = new char[fieldSize][];

            InitializeFieldAndFindPersonsPositions(fieldSize,ref field);

            while (energy > 0)
            {
                string[] input = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string direction = input[0];
                int enemyRow = int.Parse(input[1]);
                int enemyCol = int.Parse(input[2]);

                field[parisRow][parisCol] = '-';
                SpawnEnemy(enemyRow, enemyCol,ref field);

                MoveParis(direction, field);
                energy--;

                char symbolOnNextStep = field[parisRow][parisCol];

                if (symbolOnNextStep == 'S')
                {
                    energy -= 2;
                    if (energy <= 0)
                    {
                        field[parisRow][parisCol] = 'X';
                        Console.WriteLine($"Paris died at {parisRow};{parisCol}.");
                        PrintField(field);
                        return;
                    }
                    else
                    {
                        field[parisRow][parisCol] = 'P';
                    }
                }
                else if (symbolOnNextStep == 'H')
                {
                    Console.WriteLine($"Paris has successfully abducted Helen! Energy left: {energy}");
                    field[parisRow][parisCol] = '-';
                    PrintField(field);
                    return;
                }
            }
            if (energy <= 0)
            {
                field[parisRow][parisCol] = 'X';
                Console.WriteLine($"Paris died at {parisRow};{parisCol}.");
                PrintField(field);
            }
        }

        private static void PrintField(char[][] field)
        {
            for (int row = 0; row < field.Length; row++)
            {
                for (int col = 0; col < field[row].Length; col++)
                {
                    Console.Write(field[row][col]);
                }
                Console.WriteLine();
            }
        }

        private static void MoveParis(string direction, char[][] field)
        {
            if (direction == "up")
            {
                if (parisRow - 1 >= 0)
                {
                    parisRow--;
                }
            }
            else if (direction == "down")
            {
                if (parisRow + 1 < field.Length)
                {
                    parisRow++;
                }
            }
            else if (direction == "left")
            {
                if (parisCol - 1 >= 0)
                {
                    parisCol--;
                }
            }
            else if (direction == "right")
            {
                if (parisCol + 1 < field[parisRow].Length)
                {
                    parisCol++;
                }
            }
        }

        private static void SpawnEnemy(int enemyRow, int enemyCol,ref char[][] field)
        {
            field[enemyRow][enemyCol] = 'S';
        }

        private static void InitializeFieldAndFindPersonsPositions(int fieldSize,ref char[][] field)
        {
            for (int row = 0; row < fieldSize; row++)
            {
                char[] currentCol = Console.ReadLine().ToCharArray();
                field[row] = new char[currentCol.Length];
                for (int col = 0; col < currentCol.Length; col++)
                {
                    field[row][col] = currentCol[col];

                    if (field[row][col] == 'P')
                    {
                        parisRow = row;
                        parisCol = col;
                    }
                }
            }
        }
    }
}
