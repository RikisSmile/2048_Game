/*
 Control.cs
 Yep just control
*/

using System;

namespace Consoleapp;

class Movement
{
    public static int score = 0;
    public static void MoveUp(int[,] board)
        {
            for (int col = 0; col < 4; col++)
            {
                for (int row = 1; row < 4; row++)
                {
                    if (board[row, col] != 0)
                    {
                        for (int r = row; r > 0; r--)
                        {
                            if (board[r - 1, col] == 0)
                            {
                                board[r - 1, col] = board[r, col];
                                board[r, col] = 0;
                            }
                            else if (board[r - 1, col] == board[r, col])
                            {
                                board[r - 1, col] *= 2;
                                board[r, col] = 0;
                                score += board[r - 1, col];
                                break;
                            }
                        }
                    }
                }
            }
        }

        public static void MoveDown(int[,] board)
        {
            for (int col = 0; col < 4; col++)
            {
                for (int row = 2; row >= 0; row--)
                {
                    if (board[row, col] != 0)
                    {
                        for (int r = row; r < 3; r++)
                        {
                            if (board[r + 1, col] == 0)
                            {
                                board[r + 1, col] = board[r, col];
                                board[r, col] = 0;
                            }
                            else if (board[r + 1, col] == board[r, col])
                            {
                                board[r + 1, col] *= 2;
                                board[r, col] = 0;
                                score += board[r + 1, col];
                                break;
                            }
                        }
                    }
                }
            }
        }

        public static void MoveLeft(int[,] board)
        {
            for (int row = 0; row < 4; row++)
            {
                for (int col = 1; col < 4; col++)
                {
                    if (board[row, col] != 0)
                    {
                        for (int c = col; c > 0; c--)
                        {
                            if (board[row, c - 1] == 0)
                            {
                                board[row, c - 1] = board[row, c];
                                board[row, c] = 0;
                            }
                            else if (board[row, c - 1] == board[row, c])
                            {
                                board[row, c - 1] *= 2;
                                board[row, c] = 0;
                                score += board[row, c - 1];
                                break;
                            }
                        }
                    }
                }
            }
        }

        public static void MoveRight(int[,] board)
        {
            for (int row = 0; row < 4; row++)
            {
                for (int col = 2; col >= 0; col--)
                {
                    if (board[row, col] != 0)
                    {
                        for (int c = col; c < 3; c++)
                        {
                            if (board[row, c + 1] == 0)
                            {
                                board[row, c + 1] = board[row, c];
                                board[row, c] = 0;
                            }
                            else if (board[row, c + 1] == board[row, c])
                            {
                                board[row, c + 1] *= 2;
                                board[row, c] = 0;
                                score += board[row, c + 1];
                                break;
                            }
                        }
                    }
                }
            }
        }
}