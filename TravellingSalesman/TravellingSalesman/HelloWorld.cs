using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravellingSalesman
{
    class HelloWorld
    {
        private string _title;

        public HelloWorld() {
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
    }
}
