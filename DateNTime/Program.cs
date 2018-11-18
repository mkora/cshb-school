using System;

namespace DateNTime
{
    class Program
    {
        static void Main(string[] args)
        {
            // Current time
            DateTime value = DateTime.Now;

            Console.WriteLine(value.ToString());
            Console.WriteLine(value.ToShortDateString());
            Console.WriteLine(value.ToShortTimeString());
            Console.WriteLine(value.ToLongDateString());
            Console.WriteLine(value.ToLongTimeString());

            // Addition
            Console.WriteLine(value.AddDays(3).ToLongDateString()); // chaining, btw
            Console.WriteLine(value.AddHours(3).ToLongTimeString());

            // Subtraction
            Console.WriteLine(value.AddDays(-3).ToLongDateString());
            Console.WriteLine(value.AddHours(-3).ToLongTimeString());

            Console.WriteLine(value.Month); // return int

            // Other dates
            DateTime other1 = new DateTime(1969, 12, 7);
            Console.WriteLine(other1.ToShortDateString());

            DateTime other2 = DateTime.Parse("12/7/1969");
            Console.WriteLine(other2.ToShortDateString());

            // Span of time (interval)
            TimeSpan age = DateTime.Now.Subtract(other1);
            Console.WriteLine(age.TotalDays);

            Console.ReadLine();
        }
    }
}
