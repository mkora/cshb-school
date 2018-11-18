using System;

namespace OperatorsExpressionsStatements
{
    class Program
    {
        static void Main(string[] args)
        {

            /**
             * Check out https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/operators/
             * 
             * There are much more to learn!
             */

            // Variable declaration
            int x, y, a, b;

            // Assigment operator
            x = 3;
            y = 2;
            a = 1;
            b = 0;

            // Mathematical operations
            x = 3 + 4; // addition
            y = 7 - 2; // subtraction
            a = 3 * 9; // multiplication
            b = 9 / 3; // division

            // Order of operations using parenthesis
            x = (x + y) * (a + b);

            // Evaluation of values
            if (x == y) // equal to operator
            { }

            if (x < y) // less then operator
            { }

            if (x > y) // greater then operator
            { }

            if (x <= y) // less then or equal to operator
            { }

            if (x >= y) // greater thenequal to operator
            { }

            // "Conditional" operators
            if ((x > y) && (a > b)) // AND operator
            { }
            if ((x > y) || (a > b)) // OR operator
            { }

            // Ternary operator
            string str = (x == 1) ? "Car" : "Boat";

            // Member accessor operator and Method invocation operator
            Console.WriteLine("Hi");

            Console.ReadLine();
        }
    }
}
