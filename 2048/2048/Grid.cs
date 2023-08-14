/*
   Grid.cs 
   Grid(board), main functions 
*/


using System;

namespace Consoleapp;

public class Grid
{

        static public int[,] board = new int[4, 4];
        static public Random random = new Random();
        static public void PrintBoard()
        {
            Console.Clear();
            Console.WriteLine("2048 Game\n");

            for (int row = 0; row < 4; row++)
            {
                for (int col = 0; col < 4; col++)
                {
                    int tileValue = board[row, col];
                    ConsoleColor tileColor = GetTileColor(tileValue);

                    Console.ForegroundColor = tileColor;
                    Console.Write($"{board[row, col], -6}");
                    Console.ResetColor(); // Reset color after printing the tile
                }

                
                Console.WriteLine();
            }

            Console.WriteLine($"Score {Movement.score}");

        }

        private static ConsoleColor GetTileColor(int tileValue)
        {
            switch (tileValue)
            {
                case 2:
                    return ConsoleColor.Yellow;
                case 4:
                    return ConsoleColor.DarkYellow;
                case 8:
                    return ConsoleColor.DarkRed;
                case 16:
                    return ConsoleColor.Red;
                case 32:
                    return ConsoleColor.DarkMagenta;
                case 64:
                    return ConsoleColor.Magenta;
                case 128:
                    return ConsoleColor.DarkCyan;
                case 256:
                    return ConsoleColor.Cyan;
                case 512:
                    return ConsoleColor.DarkBlue;
                case 1024:
                    return ConsoleColor.Blue;
                case 2048:
                    return ConsoleColor.DarkGreen; 
                case 4096:
                    return ConsoleColor.Gray;
                default:
                    return ConsoleColor.White;
            }
        }

        public static void GenerateRandomNumber()
        {
            int randomNumber = random.Next(1, 3) * 2; // Generates either 2 or 4
            int emptyCellCount = CountEmptyCells();

            if (emptyCellCount == 0)
                return;

            int randomIndex = random.Next(0, emptyCellCount);
            int count = 0;

            for (int row = 0; row < 4; row++)
            {
                for (int col = 0; col < 4; col++)
                {
                    if (board[row, col] == 0)
                    {
                        if (count == randomIndex)
                        {
                            board[row, col] = randomNumber;
                            return;
                        }
                        count++;
                    }
                }
            }
        }

        public static int CountEmptyCells()
        {
            int count = 0;
            for (int row = 0; row < 4; row++)
            {
                for (int col = 0; col < 4; col++)
                {
                    if (board[row, col] == 0)
                        count++;
                }
            }
            return count;
        }

        public static bool IsGameOver()
        {
          if (CountEmptyCells() == 0)
          {
            return true;
          }
          return false;
        }

        public static bool Win()
        {
            for (int row = 0; row < 4; row++)
            {
                for (int col = 0; col < 4; col++)
                {
                    if (Program.continueGame)
                    {
                        return false;
                    }
                    if (board[row, col] == 2048)
                    {
                       return true;
                    }
                }
            }
            return false;
        }
}