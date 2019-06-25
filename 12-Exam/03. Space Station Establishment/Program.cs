using System;

namespace _03._Space_Station_Establishment
{
    class Program
    {
        public static int stephensRow;
        public static int stephensCol;
        public static int firstBlackHoleRow;
        public static int firstBlackHoleCol;
        public static int secondBlackHoleRow;
        public static int secondBlackHoleCol;
        public static char[,] galaxy;

        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            bool isBlackHoleReaded = false;
            galaxy = new char[size, size];
            int collectedStarEnergy = 0;

            for (int row = 0; row < size; row++)
            {
                char[] currentRow = Console.ReadLine().ToCharArray();
                for (int col = 0; col < currentRow.Length; col++)
                {
                    galaxy[row, col] = currentRow[col];
                    if (galaxy[row,col] == 'S')
                    {
                        stephensRow = row;
                        stephensCol = col;
                    }
                    if (isBlackHoleReaded == false)
                    {
                        if (galaxy[row,col] == 'O')
                        {
                            firstBlackHoleRow = row;
                            firstBlackHoleCol = col;
                            isBlackHoleReaded = true;
                        }
                    }
                    else
                    {
                        if (galaxy[row, col] == 'O')
                        {
                            secondBlackHoleRow = row;
                            secondBlackHoleCol = col;
                        }
                    }
                }
            }

            while (true)
            {
                string move = Console.ReadLine();
                galaxy[stephensRow, stephensCol] = '-';
                MoveStephen(move);

                if (IsInVoid())
                {
                    Console.WriteLine($"Bad news, the spaceship went to the void.");
                    break;
                }
                if (Char.IsDigit(galaxy[stephensRow, stephensCol]))
                {
                    int currentEnergy = 0;
                    char currentChar = galaxy[stephensRow, stephensCol];
                    int.TryParse(currentChar.ToString(), out currentEnergy);
                    collectedStarEnergy += currentEnergy;
                    galaxy[stephensRow, stephensCol] = 'S';
                }
                if (galaxy[stephensRow, stephensCol] == 'O')
                {
                    if (stephensRow == firstBlackHoleRow && stephensCol == firstBlackHoleCol)
                    {
                        stephensRow = secondBlackHoleRow;
                        stephensCol = secondBlackHoleCol;
                        galaxy[firstBlackHoleRow, firstBlackHoleCol] = '-';
                        galaxy[stephensRow, stephensCol] = 'S';
                    }
                    else if (stephensRow == secondBlackHoleRow && stephensCol == secondBlackHoleCol)
                    {
                        stephensRow = firstBlackHoleRow;
                        stephensCol = firstBlackHoleCol;
                        galaxy[secondBlackHoleRow, secondBlackHoleCol] = '-';
                        galaxy[stephensRow, stephensCol] = 'S';
                    }
                }
                if (collectedStarEnergy >= 50)
                {
                    Console.WriteLine($"Good news! Stephen succeeded in collecting enough star power!");
                    break;
                }
            }

            Console.WriteLine($"Star power collected: {collectedStarEnergy}");

            for (int row = 0; row < size; row++)
            {
                for (int col = 0; col < size; col++)
                {
                    Console.Write(galaxy[row,col]);
                }
                Console.WriteLine();
            }
        }

        private static void MoveStephen(string move)
        {
            if (move == "up")
            {
                stephensRow--;
            }
            else if (move == "down")
            {
                stephensRow++;
            }
            else if (move == "left")
            {
                stephensCol--;
            }
            else if (move == "right")
            {
                stephensCol++;
            }
        }

        private static bool IsInVoid()
        {
            if (stephensRow < 0 
                || stephensRow >= galaxy.GetLength(0) 
                || stephensCol < 0 
                || stephensCol >= galaxy.GetLength(1))
            {
                return true;
            }
            return false;
        }
    }
}
