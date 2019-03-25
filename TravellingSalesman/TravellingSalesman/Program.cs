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
            board.ReprintBoard();

            // prevent quit
            Console.ReadLine();

            
        }
    }
}
