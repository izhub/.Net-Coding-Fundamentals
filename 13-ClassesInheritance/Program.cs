using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_ClassesInheritance
{
    class Program
    {
        //working with abstract base class
        static void Main(string[] args)
        {
            car mycar = new car();
            mycar.Make = "BWM";
            mycar.Model = "745li";
            mycar.Color = "Black";
            mycar.Year = 2005;

            printVehicleDetails(mycar);

            Truck mytruck = new Truck();
            mytruck.Make = "Ford";
            mytruck.Model = "F950";
            mytruck.Year = 2006;
            mytruck.Color = "Black";
            mytruck.TowingCapacity = 1200;
            printVehicleDetails(mytruck);

            Console.ReadLine();
        }

        private static void printVehicleDetails(Vehicle vehicle)
        {
            Console.WriteLine("Here are the vehicle's details: {0}", vehicle.FormatMe());
        }

        abstract class Vehicle
        {
            public string Make { get; set; }
            public string Model { get; set; }
            public int Year { get; set; }
            public string Color { get; set; }

            public abstract string FormatMe();
        }

        class car : Vehicle
        {

            //virtual allows to offer override
            //abstract says you have to change it
            public override string FormatMe()
            {
                return String.Format("{0} - {1} - {2} - {3}", this.Make, this.Model, this.Color, this.Year);

            }
        }
        //sealed prohibits from inheriting 
        sealed class Truck : Vehicle
        {
            public int TowingCapacity { get; set; }

            public override string FormatMe()
            {
                return String.Format("{0} - {1} - {2} Towing units", this.Make, this.Model, this.TowingCapacity);

            }

        }
    }
}
