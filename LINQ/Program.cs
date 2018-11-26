using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            /**
             * <VAR> means that the type of the local being declared will be inferred by the compiler
             * 
             * <VAR> has only two uses:
             * - It requires less typing to declare variables, especially when declaring 
             *      a variable as a nested generic type.
             * - It must be used when storing a reference to an object of an anonymous type,
             *      because the type name cannot be known in advance: var foo = new { Bar = "bar" };
             */

            /**
             * Introduction to LINQ:
             * https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/concepts/linq/introduction-to-linq
             * 
             * 101 LINQ Samples:
             * https://code.msdn.microsoft.com/101-LINQ-Samples-3fb9811b
             * 
             */

            List<Car> myCars = new List<Car>() {
                new Car() { VIN="A1", Make = "BMW", Model= "550i", StickerPrice=55000, Year=2009},
                new Car() { VIN="B2", Make="Toyota", Model="4Runner", StickerPrice=35000, Year=2010},
                new Car() { VIN="C3", Make="BMW", Model = "745li", StickerPrice=75000, Year=2008},
                new Car() { VIN="D4", Make="Ford", Model="Escape", StickerPrice=25000, Year=2008},
                new Car() { VIN="E5", Make="BMW", Model="55i", StickerPrice=57000, Year=2010}
            };

            // LINQ Query Syntax
            var bmws1 = from car in myCars
                       where car.Make == "BMW" && car.Year == 2010
                       select car;
            foreach (var car in bmws1)
            {
                Console.WriteLine("{0} {1}", car.VIN, car.Model);
            }
            Console.Write("\n");

            // sorting
            var orderedCars1 = from car in myCars
                              orderby car.Year descending
                              select car;
            foreach (var car in orderedCars1)
            {
                Console.WriteLine("{0} {1} {2}", car.Year, car.VIN, car.Model);
            }
            Console.Write("\n");

            var bmws3 = from car in myCars
                        where car.Make == "BMW" && car.Year == 2010
                        select new { car.VIN, car.Model}; // projection (to a new anonymous data type)
            foreach (var car in bmws3)
            {
                Console.WriteLine("{0} {1}", car.VIN, car.Model);
            }
            Console.Write("\n");


            // LINQ Method Syntax
            var bmws2 = myCars.Where(p => p.Make == "BMW" && p.Year == 2010);
            foreach (var car in bmws2)
            {
                Console.WriteLine("{0} {1}", car.VIN, car.Model);
            }
            Console.Write("\n");

            // sorting
            var orderedCars2 = myCars.OrderByDescending(p => p.Year);
            foreach (var car in orderedCars2)
            {
                Console.WriteLine("{0} {1} {2}", car.Year, car.VIN, car.Model);
            }
            Console.Write("\n");

            // one item
            var firstCar1 = myCars.First(p => p.Make == "BMW");
            Console.WriteLine("{0} {1} {2}", firstCar1.Year, firstCar1.VIN, firstCar1.Model);
            Console.Write("\n");

            var firstCar2 = myCars.OrderByDescending(p => p.Year).First(p => p.Make == "BMW");
            Console.WriteLine("{0} {1} {2}", firstCar2.Year, firstCar2.VIN, firstCar2.Model);
            Console.Write("\n");

            // conditions: eq. is it true that ...
            Console.WriteLine(myCars.TrueForAll(p => p.Year > 2007));
            Console.Write("\n");
            Console.WriteLine(myCars.Exists(p => p.Model == "745li"));
            Console.Write("\n");

            // FOREACH loop
            myCars.ForEach(p => p.StickerPrice -= 3000);
            myCars.ForEach(p => Console.WriteLine("{0} {1:C}", p.VIN, p.StickerPrice));
            Console.Write("\n");

            // aggregator functions
            Console.WriteLine(myCars.Sum(p => p.StickerPrice));
            Console.Write("\n");

            // Standard method of all Objects
            Console.WriteLine(myCars.GetType());
            Console.WriteLine(orderedCars1.GetType()); // that's why we use VAR
            Console.WriteLine(firstCar1.GetType());
            Console.Write("\n");

            Console.ReadKey();
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
