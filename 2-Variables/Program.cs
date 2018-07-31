using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            int x;
            int y;

            x = 7;
            y = x + 3;

            Console.WriteLine(y);
            Console.ReadLine();
            */

            Console.WriteLine("What's your name? ");
            Console.Write("Type your first name: ");
            string firstName;
            firstName = Console.ReadLine();

            /*
            Console.Write("What's your last name? ");
            Console.Write("Type your last name: ");
            string lastName;
            lastName = Console.ReadLine();
            */

            Console.Write("Type your last name: ");
            string myLastName = Console.ReadLine();

            Console.WriteLine("Hello, " + firstName + " " + myLastName);
            Console.ReadLine();

        }
    }
}
