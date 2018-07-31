using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_OperatorsExpressionsStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            //variable declaration
            int x, y, a, b;

            //assignment operator
            x = 3;
            y = 2;
            a = 1;
            b = 0;

            //ther are many math operators...

            //addition operator
            x = 3 + 4;

            //substraction operator
            x = 10 - 5;

            //multiplication operator
            x = 3 * 5;

            //division operator
            x = 10 / 5;

            // order of operations using paranthesis
            x = (x + y) * (a - b);

            //there are many operators used to evaluate values...

            //equality operator
            if (x == y)
            {
            }

            //greator than operatoer
            if (x > y)
            {
            }

            //less than operator
            if (x < y)
            {
            }


            //there are two "conditional" ooperators as well that can
            // be used to expand / enhance an evaluation...
            //... and they can be combined together multiple times

            //contional AND operator
            if ((x > y) && (a > b))
            {
            }

            //contional OR operator
            if ((x> y) || (a > b))
            {
            }

            //also, hre's the in-line condinational operator we
            // learned about in previous lesson...
            string message = (x == 1) ? "car" : "Boat";

            //Member access and Method invocation
            Console.WriteLine("hi");

        }
    }
}
