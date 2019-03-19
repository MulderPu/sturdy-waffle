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
            bool flag = true;
            Message msg = new Message("Hello World! \nWelcome Back!");
            msg.PrintMessage();

            while (flag)
            {
                // receive input
                Console.WriteLine("Enter your name?");
                string input = Console.ReadLine();
                //Console.WriteLine("Your name is {0}", input);

                if (input != "exit")
                {
                    PascalCase newPascalCase = new PascalCase(input.ToLower());
                    Console.WriteLine("-----------------------------------------");
                }
                else {
                    flag = false;
                    msg.SetMessage("Ok, Bye!");
                    msg.PrintMessage();
                }
            }

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

        public void PrintMessage()
        {
            Console.WriteLine(text);
        }

        public void SetMessage(string _text) {
            text = _text;
        }
    }

    public class PascalCase
    {
        public PascalCase(string _text)
        {

            string reply = "Who are you?";
            switch (_text)
            {
                case "james":
                    reply = "Oh, You are back!";
                    break;
                case "alex":
                    reply = "Long time no see!";
                    break;
                case "sharon":
                    reply = "Beautiful, are you single?";
                    break;
                case "bryan":
                    reply = "Fat as always.";
                    break;
            }

            Message newMessage = new Message(reply);
            newMessage.PrintMessage();
        }
    }
}
