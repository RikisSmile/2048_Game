/*
 Cheats.cs
*/

using System;

namespace Consoleapp;

class Cheats
{
    public static void Ad(int n)
    {
        int randomNumber = Grid.random.Next(1, 3) * 2; 
        int emptyCellCount = Grid.CountEmptyCells();

        if (emptyCellCount == 0)
            return;

            int randomIndex = Grid.random.Next(0, emptyCellCount);
            int count = 0;

            for (int row = 0; row < 4; row++)
            {
                for (int col = 0; col < 4; col++)
                {
                    if (Grid.board[row, col] == 0)
                    {
                        if (count == randomIndex)
                        {
                            Grid.board[row, col] = n;
                            return;
                        }
                        count++;
                    }
                }
            }
    }

    public static void Clear()
    {
        for (int row = 0; row < 4; row++)
            {
                for (int col = 0; col < 4; col++)
                {
                    Grid.board[row, col] = 0;
                }
            }
    }
}