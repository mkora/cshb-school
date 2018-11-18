using System;

namespace HelperMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The Name Game");

            Console.Write("What's your first name? ");
            string firstName = Console.ReadLine();

            Console.Write("What's your last name? ");
            string lastName = Console.ReadLine();

            Console.Write("In what city were you born? ");
            string city = Console.ReadLine();

            DisplayResults(ReverseString(firstName),
                ReverseString(lastName),
                ReverseString(city));

            // or
            Console.WriteLine();

            DisplayResults(ReverseString(firstName) + " "
                + ReverseString(lastName) + " "
                + ReverseString(city));

            Console.ReadLine();
        }

        private static string ReverseString(string message) 
        {
            char[] messageArray = message.ToCharArray(); // String.ToCharArray
            Array.Reverse(messageArray);                 // Array.Reverse  
            return String.Concat(messageArray);          // String.Concat
        }

        private static void DisplayResults(
            string firstName,
            string lastName,
            string city)
        {
            Console.Write("Results: ");
            Console.Write(String.Format("{0} {1} {2}", firstName, lastName, city)); // String.Format
        }

        // Overriding a method
        private static void DisplayResults(string message)
        {
            Console.Write("Results: ");
            Console.Write(message);
        }
    }
}
