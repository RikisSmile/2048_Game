using System;

namespace Consoleapp
{
    class Program
    {
        public static bool continueGame = false;


        static void Main()
        {
            // Something like Init
            Grid.GenerateRandomNumber();
            Grid.GenerateRandomNumber();

            while (true)
            {
                Grid.PrintBoard();
                ConsoleKeyInfo keyInfo = Console.ReadKey();
                Console.WriteLine();

                switch (keyInfo.Key)
                {
                    case ConsoleKey.UpArrow:
                        Movement.MoveUp(Grid.board);
                        break;
                    case ConsoleKey.DownArrow:
                        Movement.MoveDown(Grid.board);
                        break;
                    case ConsoleKey.LeftArrow:
                        Movement.MoveLeft(Grid.board);
                        break;
                    case ConsoleKey.RightArrow:
                        Movement.MoveRight(Grid.board);
                        break;
                    case ConsoleKey.X:
                        Cheats.Ad(128);
                        break;
                    case ConsoleKey.V:
                        Cheats.Ad(256);
                        break;
                    case ConsoleKey.B:
                        Cheats.Ad(512);
                        break;
                    case ConsoleKey.N:
                        Cheats.Ad(1024);
                        break;
                    case ConsoleKey.M:
                        Cheats.Ad(2048);
                        break;
                    case ConsoleKey.C:
                        Cheats.Clear();
                        break;
                    default:
                        Console.WriteLine("Invalid input. Use arrow keys to play.");
                        break;
                }

                if (Grid.IsGameOver())
                {
                    Console.WriteLine("Game Over");
                    Console.WriteLine($"Score: {Movement.score}");
                    return;
                }


                if (Grid.Win())
                {
                    if (continueGame)
                        Main();

                    Console.WriteLine("Win");
                    Console.WriteLine("Do you want to continue? (y/n)");
                    string response = Console.ReadLine();
                    if (response == "y" || response == "Y")
                        continueGame = true;
                    else
                        return;
                }

                Grid.GenerateRandomNumber();
            }

        }
    }
}


 