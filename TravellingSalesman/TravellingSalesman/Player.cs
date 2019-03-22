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

        public Player(string name, string citiesNumber, string steps)
        {
            _name = name;
            _citiesNumber = citiesNumber;
            _steps = steps;
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
