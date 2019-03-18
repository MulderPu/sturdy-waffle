using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Program
    {

        static void Main(string[] args)
        {
            Message msg = new Message("Hello World");
            msg.printMessage();
            // prevent exit
            Console.ReadLine();
        }


    }

    public class Message
    {

        // variables
        private string text;

        public Message(string txt)
        {
            text = txt;
        }

        public void printMessage()
        {
            Console.WriteLine(text);
        }


    }
}
