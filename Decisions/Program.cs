using System;

namespace Decisions
{
    class Program
    {
        static void Main(string[] args)
        {
            // if - if-else - else
            Console.WriteLine("B's Big Giveaway: First try");
            Console.Write("Choose door 1, 2, or 3: ");
            string userValue1 = Console.ReadLine();

            string message1 = "";

            if (userValue1 == "1")
                // inner scope
                message1 = "You won a new car!";
            else if (userValue1 == "2")
                message1 = "You won a new boat!";
            else if (userValue1 == "3")
                message1 = "You won a new cat!";
            else
            {
                message1 = "Sorry, I don't understand. ";
                message1 += "You're lose!";
            }

            Console.WriteLine(message1);

            // ternary operator
            Console.WriteLine("B's Big Giveaway: Second try");
            Console.Write("Choose door 1, 2, or 3: ");
            string userValue2 = Console.ReadLine();

            string message2 = (userValue2 == "1") ? "a car" : "a cat";
            Console.WriteLine("You entered {0}, therefore you won {1}.", userValue2, message2); // NOTE: replacement codes
        }
    }
}
