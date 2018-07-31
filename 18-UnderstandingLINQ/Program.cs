using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_UnderstandingLINQ
{
    class Program
    {
        //2 styles : query syntax similar to sql; method synstax familiar to c# devs
        static void Main(string[] args)
        {
            List<Car> myCars = new List<Car>() {
                new Car() { VIN="A1", Make = "BMW", Model= "550i", StickerPrice=55000, Year=2009},
                new Car() { VIN="B2", Make="Toyota", Model="4Runner", StickerPrice=35000, Year=2010},
                new Car() { VIN="C3", Make="BMW", Model = "745li", StickerPrice=75000, Year=2008},
                new Car() { VIN="D4", Make="Ford", Model="Escape", StickerPrice=25000, Year=2008},
                new Car() { VIN="E5", Make="BMW", Model="55i", StickerPrice=57000, Year=2010}
            };

            //LINQ Query
            /*
            var bmws = from car in myCars
                       where car.Make == "BMW"
                       && car.Year == 2010
                       select car;

            */

            /*
            var orderedCars = from car in myCars
                              orderby car.Year descending
                              select car;

            */

            //LINQ method
            //lamba expressions - mini methods
            //var bmws = myCars.Where(p => p.Make == "BMW" && p.Year == 2010);

            //var orderedCars = myCars.OrderByDescending(p => p.Year);

            /*
            var firstBWM = myCars.OrderByDescending(p => p.Year).First(p => p.Make == "BMW");
            Console.WriteLine(firstBWM.VIN);
            */

            // Console.WriteLine(myCars.TrueForAll(p => p.Year > 2009));

            //myCars.ForEach(p => p.StickerPrice -= 3000);
            //myCars.ForEach(p => Console.WriteLine("{0} {1:C}", p.VIN, p.StickerPrice));

            //Console.WriteLine(myCars.Exists(p => p.Model == "745li"));

            //Console.WriteLine(myCars.Sum(p => p.StickerPrice));

            /*
            foreach (var car in orderedCars)
            {
                Console.WriteLine("{0} {1}", car.Year, car.Model, car.VIN);
            }
            */


            /*
            Console.WriteLine(myCars.GetType());  
            var orderedCars = myCars.OrderByDescending(p => p.Year);
            Console.WriteLine(orderedCars.GetType());

            var bmws = myCars.Where(p => p.Make == "BMW" && p.Year == 2010);
            Console.WriteLine(bmws.GetType());
            

            var newCars = from car in myCars
                       where car.Make == "BMW"
                       && car.Year == 2010
                       select new { car.Make, car.Model }; //projection = selection new datatypes to project at runtime
            Console.WriteLine(newCars.GetType());
            */

            Console.ReadLine();
        }
    }


    class Car
    {
        public string VIN { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public double StickerPrice { get; set; }
    }
}
