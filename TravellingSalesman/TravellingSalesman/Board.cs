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

        public void PrintBoard()
        {
            //Console.WriteLine(_board.GetLength(0));
            //Console.WriteLine(_board.GetLength(1));

            for (int i = 0; i < _board.GetLength(0); i++)
            {
                for (int j = 0; j < _board.GetLength(1); j++)
                {
                    _board[i, j] = "*";
                    Console.Write(_board[i, j]);
                }
                Console.WriteLine();
            }
        }
    }
}
