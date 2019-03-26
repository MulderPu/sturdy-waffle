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
        int _X = 0;
        int _Y = 0;
        public const string Alphabet =
        "ABCDEFGHIJKLMNOPQRSTUVWXYZ";

        public Board(int tilesX, int tilesY)
        {
            _board = new string[tilesX, tilesY];
            _X = tilesX;
            _Y = tilesY;
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

        public void ReprintBoard()
        {
            Console.Clear();
            for (int i = 0; i < _board.GetLength(0); i++)
            {
                Console.WriteLine("");
                for (int j = 0; j < _board.GetLength(1); j++)
                {
                    Console.Write(" ");
                    Console.Write(_board[i, j]);
                    Console.Write(" ");
                }
                Console.WriteLine();
            }
        }

        public void SetCityToBoard()
        {
            int number = (_X + _Y) / 2;
            var fooArray = Alphabet.ToCharArray().Select(c => c.ToString()).ToArray();
            String[] randomLetter = new String[number];
            Random rnd = new Random();

            bool flag = true;
            int i = 0;
            while (flag)
            {
                int randNum = rnd.Next(0, fooArray.Length);
                if (randomLetter.Contains(fooArray[randNum]) == false)
                {
                    // not exist , add in
                    randomLetter[i] = fooArray[randNum];
                    i++;
                }

                if (i == randomLetter.Length)
                {
                    flag = false;
                }
            }

            foreach (var item in randomLetter)
            {
                bool flag2 = true;
                while (flag2)
                {
                    int num1 = rnd.Next(1, _X);
                    Console.WriteLine("num1: {0}", num1);
                    int num2 = rnd.Next(1, _Y);
                    Console.WriteLine("num2: {0}", num2);

                    if (_board[num1, num2] == "*")
                    {
                        _board[num1, num2] = item;
                        flag2 = false;
                    }
                }
            }
        }

        public void SetPlayerPosition(int posX,int posY)
        {
            _board[posX, posY] = "@";
        }

        public void SetPreviousPosition(int posX, int posY)
        {
            _board[posX, posY] = "*";
        }

        public void ShowInstruction()
        {
            Console.WriteLine("Press '6' to move right");
            Console.WriteLine("Press '4' to move left");
            Console.WriteLine("Press '8' to move up");
            Console.WriteLine("Press '2' to move down");
            Console.Write("Please choose your next action (Press 'Q' to quit):");
        }

        public int X
        {
            get
            {
                return _X;
            }
            set
            {
                _X = value;
            }
        }

        public int Y
        {
            get
            {
                return _Y;
            }
            set
            {
                _Y = value;
            }
        }

        public static char GetRandomCharacter(string text, Random rng)
        {
            int index = rng.Next(text.Length);
            return text[index];
        }
    }
}
