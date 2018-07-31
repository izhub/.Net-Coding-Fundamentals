using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_WorkingWithStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            //string myString = "My \"so-called\" life";            //quotes
            //string myString = "What if I needa]nnew line?";      //new line
            //string myString = "Go to your C:\\ drive";         //backslsh
            //string myString = @"Go to your C:\ drive";        //blackslash 2 

            //string myString = String.Format("{1} = {0}", "First", "Second");

            //string myString = String.Format("{0:C}", 1234);
            //string myString = String.Format( "{0:N}", 123456789);
            //string myString = String.Format("Percentage: {0:P}", .1234);
            //string myString = String.Format("Phone Number: {0:(###)-(###)-(####)", 1234567890);

            //string myString = ("That summer we took three across the bard ");

            ////myString = myString.Substring(6, 14);
            //myString = myString.ToUpper();
            //myString = myString.Replace(" ", "--");
            //myString = myString.Remove(6, 14);

            /*
            myString = String.Format("Length before : {0} -- length after: {1}",
                myString.Length, myString.Trim().Length);
             */

            StringBuilder myString = new StringBuilder();
            for (int i = 0; i < 100; i++)
            {
                myString.Append("--");
                myString.Append(i);
            }

            Console.WriteLine(myString);
            Console.ReadLine();
        }
    }
}
