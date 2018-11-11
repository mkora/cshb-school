using System;

namespace WhileIteration
{
    class Program
    {
        static void Main(string[] args)
        {
            bool displayMenu = true;

            while (displayMenu)
            {
                displayMenu = MainMenu();
            }
        }

        private static bool MainMenu()
        {
            Console.Clear();
            Console.WriteLine("Choose an option: ");
            Console.WriteLine("1) Print Numbers");
            Console.WriteLine("2) Guessing Game");
            Console.WriteLine("3) Exit");

            string result = Console.ReadLine();

            if (result == "1")
                PrintNumbers();
            else if (result == "2")
                GuessingGame();
            else if (result == "3")
                return false;

            return true;
        }

        private static void PrintNumbers()
        {
            Console.Clear();
            Console.WriteLine("Print numbers");
            Console.Write("Type a number: ");

            int result = int.Parse(Console.ReadLine()); // int.Parse
            int counter = 1;
            while (counter < (result + 1))
            {
                Console.Write(counter);
                Console.Write(" ");
                counter++;
            }

            Console.ReadLine();
        }

        private static void GuessingGame()
        {
            Console.Clear();
            Console.WriteLine("Guessing Game");

            Random RandomObject = new Random();  // Random
            int randomNumber = RandomObject.Next(1, 11);

            int guesses = 0;
            bool incorrect =  true;

            do
            {
                Console.WriteLine("Guess a number between 1 and 10: ");
                string number = Console.ReadLine();

                guesses++;

                incorrect = !(number == randomNumber.ToString());
                if (incorrect)
                {
                    Console.WriteLine("Wrong!");
                }
            } while (incorrect);

            Console.WriteLine("Correct! It took you {0} guesses", guesses);
            Console.ReadLine();
        }
    }
}
