using System;
using System.Collections.Generic;
using System.Text;

namespace Subystems
{
    class BuySystem
    {
        public bool Buy()
        {
            string data = "";
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Card number");
            data = Console.ReadLine();

            if (data == "123")
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Accepted");
                return true;

            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Declined");
                return false;
            }
        }
    }

    class Store
    {
        private int quant;
        public Store()
        {
            quant = 3;
        }

        public bool GetOut()
        {
            if (quant > 0)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Send");
                quant--;
                return true;
                

            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Out of store");
                return false;

            }
        }

    }

    class SendSubsystem
    {

        public void Snd()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Sending");

        }



    }
}


