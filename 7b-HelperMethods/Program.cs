using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7b_HelperMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            // using helper methods

            Console.WriteLine("The Name Game");

            Console.Write("What's your first name: ");
            string firstName = Console.ReadLine();

            Console.Write("What's your last name: ");
            string lastName = Console.ReadLine();

            Console.Write("What city are you in? ");
            string city = Console.ReadLine();

            DisplayResult(ReverseString(firstName), ReverseString(lastName), ReverseString(city));

            Console.ReadLine();

        }

        private static string ReverseString(string message)
        {
            char[] msgArray = message.ToCharArray();
            Array.Reverse(msgArray);
            return String.Concat(msgArray);
        }

        private static void DisplayResult(string reversedFirstName, string reversedLastName,string reversedCity)
        {
            Console.Write("Results: ");
            Console.Write(String.Format("{0} {1} {2})", reversedFirstName, reversedLastName, reversedCity));
        }

        private static void DisplayResult(string message)
        {
            Console.Write("Results: ");
            Console.Write(message);
        }
    }
}
