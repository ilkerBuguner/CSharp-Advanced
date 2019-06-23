using System;

namespace _02._Tron_Racers__Multidimensional_Arrays_
{
    public class Player
    {
        public int X { get; set; }
        public int Y { get; set; }
        public char Trail { get; set; }
        public int MatrixSize { get; set; }

        public Player(int x, int y, char trail, int matrixSize)
        {
            X = x;
            Y = y;
            Trail = trail;
            MatrixSize = matrixSize;
        }

        public void MoveUp()
        {
            X--;
            if (X < 0)
            {
                X = MatrixSize - 1;
            }
        }
        public void MoveDown()
        {
            X++;
            if (X >= MatrixSize)
            {
                X = 0;
            }
        }

        public void MoveLeft()
        {
            Y--; ;
            if (Y < 0)
            {
                Y = MatrixSize - 1;
            }
        }

        public void MoveRight()
        {
            Y++;
            if (Y >= MatrixSize)
            {
                Y = 0;
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            char firstPlayerTrail = 'f';
            int firstPlayerX = 0;
            int firstPlayerY = 0;
            char secondPlayerTrail = 's';
            int secondPlayerX = 0;
            int secondPlayerY = 0;
            bool isEnd = false;

            char[,] matrix = new char[size, size];

            for (int row = 0; row < size; row++)
            {
                char[] currentRow = Console.ReadLine().ToCharArray();
                for (int col = 0; col < size; col++)
                {
                    matrix[row, col] = currentRow[col];

                    if (matrix[row, col] == 'f')
                    {
                        firstPlayerX = row;
                        firstPlayerY = col;
                    }
                    if (matrix[row, col] == 's')
                    {
                        secondPlayerX = row;
                        secondPlayerY = col;
                    }
                }
            }

            Player firstPlayer = new Player(firstPlayerX, firstPlayerY, firstPlayerTrail, size);
            Player secondPlayer = new Player(secondPlayerX, secondPlayerY, secondPlayerTrail, size);

            while (!isEnd)
            {
                string[] moveCommands = Console.ReadLine().Split();
                string firstPlayerMove = moveCommands[0];
                string secondPlayerMove = moveCommands[1];

                if (firstPlayerMove == "up")
                {
                    firstPlayer.MoveUp();
                }
                else if (firstPlayerMove == "down")
                {
                    firstPlayer.MoveDown();
                }
                else if (firstPlayerMove == "right")
                {
                    firstPlayer.MoveRight();
                }
                else if (firstPlayerMove == "left")
                {
                    firstPlayer.MoveLeft();
                }

                if (matrix[firstPlayer.X, firstPlayer.Y] == 's')
                {
                    matrix[firstPlayer.X, firstPlayer.Y] = 'x';
                    isEnd = true;
                }
                if (matrix[firstPlayer.X, firstPlayer.Y] == '*')
                {
                    matrix[firstPlayer.X, firstPlayer.Y] = 'f';
                }

                if (isEnd)
                {
                    break;
                }

                if (secondPlayerMove == "up")
                {
                    secondPlayer.MoveUp();
                }
                else if (secondPlayerMove == "down")
                {
                    secondPlayer.MoveDown();
                }
                else if (secondPlayerMove == "right")
                {
                    secondPlayer.MoveRight();
                }
                else if (secondPlayerMove == "left")
                {
                    secondPlayer.MoveLeft();
                }

                if (matrix[secondPlayer.X, secondPlayer.Y] == 'f')
                {
                    matrix[secondPlayer.X, secondPlayer.Y] = 'x';
                    isEnd = true;
                }
                if (matrix[secondPlayer.X, secondPlayer.Y] == '*')
                {
                    matrix[secondPlayer.X, secondPlayer.Y] = 's';
                }

                if (isEnd)
                {
                    break;
                }

            }

            for (int row = 0; row < size; row++)
            {
                for (int col = 0; col < size; col++)
                {
                    Console.Write(matrix[row,col]);
                }
                Console.WriteLine();
            }

        }
    }
}
