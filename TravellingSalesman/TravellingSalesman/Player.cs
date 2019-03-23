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

        public Player(string name)
        {
            _name = name;
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
