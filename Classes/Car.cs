using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public class Car
    {

        public string Make;

        public string Model;

        public int Year;

        public List<string> OwnerHistory;

        public double Mileage { get; private set; } // <-- Auto-property

        private readonly static int NumWheels = 4;

        public Car() // <-- Default constructor
        {
            Make = "";

            Model = "";

            Year = 2018;

            Mileage = 0.00;

            OwnerHistory = new List<string>();

        }

        public Car(string make, string model, int year, double mileage) : this() // <-- Constructor chaining
        {
            Make = make;

            Model = model;

            Year = year;

            Mileage = mileage;
        }

        public void AddMiles(double value)
        {
            if (value < 0)
            {
                throw new ArgumentOutOfRangeException("An error occured. Please, provide a positive number of miles");
            }

            Mileage += value;
        }

        public static int GetNumWheels()
        {
            return Car.NumWheels;
        }

    }
}
