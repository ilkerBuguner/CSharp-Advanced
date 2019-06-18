using System;
using System.Linq;

namespace _Demo__CSharp_Advanced_Exam___16._06._2019
{
    class Program
    {
        static void Main(string[] args)
        {
            int matrixRows = int.Parse(Console.ReadLine());
            char[][] matrix = new char[matrixRows][];
            int lettuceCount = 0;
            int potatoesCount = 0;
            int carrotsCount = 0;
            int harmedVegetables = 0;

            for (int row = 0; row < matrixRows; row++)
            {
                matrix[row] = Console.ReadLine().Split().Select(char.Parse).ToArray();
            }

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "End of Harvest")
                {
                    break;
                }

                string[] tokens = input.Split();
                if (tokens[0] == "Harvest")
                {
                    int row = int.Parse(tokens[1]);
                    int col = int.Parse(tokens[2]);

                    if (IsInRange(row, col, matrix))
                    {
                        if (matrix[row][col] == 'L')
                        {
                            lettuceCount++;
                        }
                        else if (matrix[row][col] == 'P')
                        {
                            potatoesCount++;
                        }
                        else if (matrix[row][col] == 'C')
                        {
                            carrotsCount++;
                        }
                        matrix[row][col] = ' ';
                    }
                }

                if (tokens[0] == "Mole")
                {
                    int row = int.Parse(tokens[1]);
                    int col = int.Parse(tokens[2]);
                    string direction = tokens[3];

                    while (IsInRange(row, col, matrix))
                    {
                        if (matrix[row][col] != ' ')
                        {
                            harmedVegetables++;
                            matrix[row][col] = ' ';
                        }
                        if (direction == "up")
                        {
                            row -= 2;
                            if (IsInRange(row, col, matrix))
                            {
                                if (matrix[row][col] != ' ')
                                {
                                    harmedVegetables++;
                                    matrix[row][col] = ' ';
                                }
                            }
                        }
                        else if (direction == "down")
                        {
                            row += 2;
                            if (IsInRange(row, col, matrix))
                            {
                                if (matrix[row][col] != ' ')
                                {
                                    harmedVegetables++;
                                    matrix[row][col] = ' ';
                                }
                            }
                        }
                        else if (direction == "left")
                        {
                            col -= 2;
                            if (IsInRange(row, col, matrix))
                            {
                                if (matrix[row][col] != ' ')
                                {
                                    harmedVegetables++;
                                    matrix[row][col] = ' ';
                                }
                            }
                        }
                        else if (direction == "right")
                        {
                            col += 2;
                            if (IsInRange(row, col, matrix))
                            {
                                if (matrix[row][col] != ' ')
                                {
                                    harmedVegetables++;
                                    matrix[row][col] = ' ';
                                }
                            }
                        }
                    }

                }
            }

            for (int row = 0; row < matrixRows; row++)
            {
                for (int col = 0; col < matrix[row].Length; col++)
                {
                    Console.Write(matrix[row][col] + " ");
                }
                Console.WriteLine();
            }

            Console.WriteLine($"Carrots: {carrotsCount}");
            Console.WriteLine($"Potatoes: {potatoesCount}");
            Console.WriteLine($"Lettuce: {lettuceCount}");
            Console.WriteLine($"Harmed vegetables: {harmedVegetables}");
        }

        public static bool IsInRange(int row, int col, char[][] matrix)
        {
            if (row >= 0 && row < matrix.GetLength(0) && col >= 0 && col < matrix[row].Length)
            {
                return true;
            }
            return false;
        }

    }
}
