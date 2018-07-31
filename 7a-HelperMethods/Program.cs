using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7a_HelperMethods
{
    class Program
    {
        static void Main(string[] args)
        {

            //before using helper methods

            Console.WriteLine("The Name Game");

            Console.Write("What's your first name? ");
            string fName = Console.ReadLine();

            Console.Write("What's your last name? ");
            string lName = Console.ReadLine();

            Console.Write("What's your city? ");
            string city = Console.ReadLine();

            char[] fNameArray = fName.ToCharArray();
            Array.Reverse(fNameArray);

            char[] lNameArray = lName.ToCharArray();
            Array.Reverse(lNameArray);

            char[] cityArray = city.ToCharArray();
            Array.Reverse(cityArray);

            string result = "";

            foreach( char item in fNameArray)
            {
                result += item;
            }

            foreach(char item in lNameArray)
            {
                result += item;
            }

            foreach(char item in cityArray)
            {
                result += item;
            }

            Console.WriteLine("Results: " + result);
            Console.ReadLine();

        }
    }
}
