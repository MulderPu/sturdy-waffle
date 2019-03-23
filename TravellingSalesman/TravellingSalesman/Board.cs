using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravellingSalesman
{
    class Board
    {
        string[,] _board;
        public Board(int tilesX, int tilesY)
        {
            _board = new string[tilesX, tilesY];
        }
        
        /// <summary>
        /// Print Game Board
        /// </summary>
        public void PrintBoard()
        {
            for (int i = 0; i < _board.GetLength(0); i++)
            {
                Console.WriteLine("");
                for (int j = 0; j < _board.GetLength(1); j++)
                {
                    Console.Write(" ");
                    _board[i, j] = "*";
                    Console.Write(_board[i, j]);
                    Console.Write(" ");
                }
                Console.WriteLine();
            }
        }
    }
}
