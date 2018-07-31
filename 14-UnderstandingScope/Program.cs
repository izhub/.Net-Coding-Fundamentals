using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_UnderstandingScope
{
    class Program
    {
        private static string k = "";

        static void Main(string[] args)
        {
            string j = "";

            for (int i = 0; i < 10; i++)
            {
                j = i.ToString();
                Console.WriteLine(i);

                if (i == 9)
                {
                    string l = i.ToString();
                }
                //Console.WriteLine(l);     //out of scope
            }

            //Console.WriteLine(i);     //out of scope
            Console.WriteLine("Outside value of for: " + j);
            Console.WriteLine("Outside for the for: " + k);

            HelperMethod();

            Car myCar = new Car();
            myCar.DoSomething();

            Console.ReadLine();
        }

        static void HelperMethod()
        {
            Console.WriteLine("Value of K from HelperMethod(): " + k);

        }


        class Car
        {
            public void DoSomething()
            {
                Console.WriteLine(helperMethod());
            }

            private string helperMethod()
            {
                return "Hello world!";
            }
        }
    }
}
