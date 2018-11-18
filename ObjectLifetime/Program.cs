using System;

namespace ObjectLifetime
{
    class Program
    {
        static void Main(string[] args)
        {
            Car myCar = new Car();
            myCar.Make = "Oldmobile";
            myCar.Model = "Cutlas Supreme";
            myCar.Year = 1986;
            myCar.Color = "Silver";

            // Coping the address (so 2 objs point to the same address)
            Car myOtherCar;
            myOtherCar = myCar;
            Console.WriteLine("{0} {1} {2} {3}", myOtherCar.Make,
                myOtherCar.Model, myOtherCar.Year, myOtherCar.Color);

            myOtherCar.Model = "98";
            Console.WriteLine("{0} {1} {2} {3}", myCar.Make,
                myCar.Model, myCar.Year, myCar.Color);

            // Remove the reference to the second obj from memory
            myOtherCar = null;

            // Check a constructor
            Car myNewCar = new Car();
            Console.WriteLine("{0} {1} {2} {3}", myNewCar.Make,
                myNewCar.Model, myNewCar.Year, myNewCar.Color);

            Car myThirdCar = new Car("Ford", "Escape", 2005, "White");
            Console.WriteLine("{0} {1} {2} {3}", myThirdCar.Make,
                myThirdCar.Model, myThirdCar.Year, myThirdCar.Color);

            // Static methods vs instance methods
            Car.MyMethod();
            // You can create static class and all its method become static too!

            Console.ReadLine();
        }
    }

    class Car
    {
        public string Make

        {
            get;
            set;
        }

        public string Model
        {
            get;
            set;
        }

        public int Year
        {
            get;
            set;
        }


        public string Color
        {
            get;
            set;
        }

        // Constructor of a class
        public Car()
        {
            Make = "Nissan";
            // this.Make = "Nissan"; // "this" is optional
        }

        // Overloaded Conatructor of a class
        public Car(string make, string model, int year, string color)
        {
            Make = make;
            Model = model;
            Year = year;
            Color = color;
        }

        public static void MyMethod() // starts with an upper case letter
        {
            Console.WriteLine("Called the static myMethod");
        }
    }
}
