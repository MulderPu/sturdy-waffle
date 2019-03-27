using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravellingSalesman
{
    class Program
    {
        static void Main(string[] args)
        {

            // print title
            HelloWorld hello = new HelloWorld();
            hello.PrintTitle();

            // print players record
            hello.PrintScore();

            // prompt user for names
            string question = "Please key in your name?";
            string name = "";
            Console.WriteLine(question);
            name = Console.ReadLine();
            Player player1 = new Player(name);
            player1.PrintGreeting();

            // prompt for board size
            string questionSize = "Set board size (W x H):";
            Console.WriteLine(questionSize);
            Console.WriteLine("Width: ");
            int tile1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Height: ");
            int tile2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please any key to start the game ~");
            Console.ReadLine();

            // create board
            Board board = new Board(tile1, tile2);
            Console.Clear();
            board.PrintBoard();
            board.SetCityToBoard();


            bool cont = true;
            while (cont)
            {
                int positionX = player1.PosX;
                int positionY = player1.PosY;
                board.SetPlayerPosition(positionX, positionY);
                // reprint game board                
                board.ReprintBoard();
                bool gameStatus = board.DisplaySteps(player1);
                board.ShowInstruction();

                if (gameStatus)
                {
                    cont = false;
                    Console.WriteLine("\n\nThanks for playing! See You...");
                }

                ConsoleKeyInfo command = Console.ReadKey();
                switch (command.Key)
                {
                    case ConsoleKey.Q:
                        cont = false;
                        Console.WriteLine("\nAw! You have quit the game.");
                        break;
                    case ConsoleKey.D6:
                    case ConsoleKey.NumPad6:
                        MoveRight(board, player1);
                        break;
                    case ConsoleKey.D2:
                    case ConsoleKey.NumPad2:
                        MoveDown(board, player1);
                        break;
                    case ConsoleKey.D4:
                    case ConsoleKey.NumPad4:
                        MoveLeft(board, player1);
                        break;
                    case ConsoleKey.D8:
                    case ConsoleKey.NumPad8:
                        MoveUp(board, player1);
                        break;
                    default:
                        break;
                }
            }


            // prevent quit
            Console.ReadLine();
        }

        private static void MoveUp(Board board, Player player)
        {
            int positionX = player.PosX;
            int positionY = player.PosY;
            int up_gaps = 0;
            int back_up = positionX - 1;

            if (back_up >= up_gaps)
            {
                board.SetPreviousPosition(positionX, positionY);
                player.PosX = back_up;
                player.StepIncrease();
            }
        }

        private static void MoveLeft(Board board, Player player)
        {
            int positionX = player.PosX;
            int positionY = player.PosY;
            int left_gaps = 0;
            int prev_pos = positionY - 1;

            if (prev_pos >= left_gaps)
            {
                board.SetPreviousPosition(positionX, positionY);
                player.PosY = prev_pos;
                player.StepIncrease();
            }
        }

        private static void MoveDown(Board board, Player player)
        {
            int positionX = player.PosX;
            int positionY = player.PosY;
            int max_tileX = board.X;
            int down_gaps = max_tileX - 1;
            int next_down = positionX + 1;

            if (next_down <= down_gaps)
            {
                board.SetPreviousPosition(positionX, positionY);
                player.PosX = next_down;
                player.StepIncrease();
            }
        }

        private static void MoveRight(Board board, Player player)
        {
            int positionX = player.PosX;
            int positionY = player.PosY;
            int max_tilesY = board.Y;
            int right_gaps = max_tilesY - 1;
            int next_pos = positionY + 1;

            if (next_pos <= right_gaps)
            {
                board.SetPreviousPosition(positionX, positionY);
                player.PosY = next_pos;
                player.StepIncrease();
            }
        }
    }
}
