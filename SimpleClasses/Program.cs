using System;

namespace SimpleClasses
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
            Console.WriteLine("{0} {1} {2} {3}", myCar.Make, 
                myCar.Model, myCar.Year, myCar.Color);

            decimal value = DetemineMarketValue(myCar);
            Console.WriteLine("{0:C}", value);

            Console.WriteLine("{0:C}", myCar.DetemineMarketValue());

            Console.ReadLine();
        }

        private static decimal DetemineMarketValue(Car car) {
            // TODO create this method, but for today it's hardcoded
            decimal value = 100.0M; // M??
            return value;
        }
    }

    class Car
    {
        public string Make // prop tab tab || propfull tab tab

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

        public decimal DetemineMarketValue()
        {
            decimal carValue = (Year > 1990) ? 10000 : 2000;
            return carValue;
        }
    } 
}
