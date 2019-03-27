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
        private int _steps;
        private int _posX;
        private int _posY;

        public Player(string name)
        {
            _name = name;
            _steps = 0;
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

        public void StepIncrease()
        {
            _steps++;
        }

        public int Steps
        {
            get
            {
                return _steps;
            }
            set
            {
                _steps = value;
            }
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
