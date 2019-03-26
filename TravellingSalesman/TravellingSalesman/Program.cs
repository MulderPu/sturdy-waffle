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
                //board.DisplaySteps();
                board.ShowInstruction();

                ConsoleKeyInfo command = Console.ReadKey();
                //Console.ReadLine();
                //String command = Console.ReadLine();
                switch (command.Key)
                {
                    case ConsoleKey.Q:
                        cont = false;
                        Console.WriteLine("Aw! You have quit the game.");
                        break;
                    case ConsoleKey.D6:
                        int max_tilesY = board.Y;
                        int right_gaps = max_tilesY - 1;
                        int next_pos = positionY + 1;

                        if (next_pos <= right_gaps)
                        {
                            board.SetPreviousPosition(positionX, positionY);
                            player1.PosY = next_pos;
                        }
                        Console.WriteLine(next_pos);
                        Console.WriteLine(max_tilesY);
                        Console.ReadLine();
                        break;
                    default:

                        break;
                }
            }
            

            // prevent quit
            Console.ReadLine();

            
        }
    }
}
