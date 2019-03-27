using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace TravellingSalesman
{
    class HelloWorld
    {
        private string _title;

        public HelloWorld()
        {
            _title = "Welcome To Travelling Salesman Problem!";
        }

        public void PrintHello()
        {
            Console.WriteLine(_title);
        }

        public void PrintTitle()
        {
            Console.WriteLine("********** {0} **********", _title);
        }

        public void PrintScore()
        {
            string fileName = "score.txt";
            Console.WriteLine("********** Previous Player's Record **********");
            Console.WriteLine("Name\tNumber of Cities\tSteps");
            string readText = File.ReadAllText(fileName);
            Console.WriteLine(readText);
        }
    }
}
