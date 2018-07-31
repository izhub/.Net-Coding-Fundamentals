using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_Decisions
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Console.WriteLine("Bob's Big Giveaway");
            Console.Write("Choose door: 1, 2 or 3: ");
            string value = Console.ReadLine();

            string msg = "";

            if (value == "1")
                msg = "you have won a car";
            else if (value == "2")
                msg = "you won a new boat!";
            else if (value == "3")
                msg = "you won a new cat!";
            else
            {
                msg = "sorry, we didn't understand. ";
                //msg = msg + "You Lose.";
                msg += "You Loose.";
            }

            Console.WriteLine(msg);
            Console.ReadLine();
            */

            Console.WriteLine("Bob's Big Giveaway");
            Console.Write("Choose a door: 1, 2 or 3: ");
            string userValue = Console.ReadLine();

            //if-else syntax = if value equals 1 then 'boat' else 'strand of lint'
            string msg = (userValue == "1") ? "boat" : "strand of lint";

            //Console.Write("You won a ");
            //Console.Write(msg);
            //Console.Write(".");
            //Console.ReadLine();

            //string manipulation {} value replaced by msg
            //Console.WriteLine("You won a {0}.", msg);
            //Console.ReadLine();

            Console.WriteLine("You entered: {0}, therefore you won a {1}.", userValue, msg);
            Console.ReadLine();

        }
    }
}
