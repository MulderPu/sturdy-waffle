using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravellingSalesman
{
    class Player
    {
        private string _name;
        private string _citiesNumber;
        private string _steps;
        int _posX;
        int _posY;

        public Player(string name)
        {
            _name = name;
            _posX = 0;
            _posY = 0;
        }
        
        /// <summary>
        /// Greeting players
        /// </summary>
        public void PrintGreeting()
        {
            string msg = "Good day " + _name + ", let's the game begun! ALL THE BEST!!!";
            Console.WriteLine("***{0}***", msg);
            Console.WriteLine();
        }

        public int PosX
        {
            get
            {
                return _posX;
            }
            set
            {
                _posX = value;
            }
        }

        public int PosY
        {
            get
            {
                return _posY;
            }
            set
            {
                _posY = value;
            }
        }

        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }
    }
}
