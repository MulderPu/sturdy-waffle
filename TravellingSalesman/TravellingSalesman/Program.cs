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


            // create board
            Board board = new Board(4, 8);
            board.PrintBoard();

            // prevent quit
            Console.ReadLine();
        }
    }
}
