using System;

namespace UnderstandingScope
{
    class Program
    {
        private static string k = "";

        static void Main(string[] args)
        {
            string j = "";
            Console.WriteLine("Start printing inside of the for-loop");
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
                j = i.ToString();
                k = i.ToString();

                if (i == 9)
                {
                    string l = i.ToString();
                }
            }
            Console.WriteLine("Printing outside of the for-loop: {0}", j);
            Console.WriteLine("Printing outside of the for-loop (method prop): {0}", k);
            HelperMethod();

            Car car = new Car();
            car.DoSomething();

            Console.ReadLine();
        }

        static void HelperMethod()
        {
            Console.WriteLine("Value of k from HelperMethod(): {0}", k);
        }

        class Car
        {
            public void DoSomething()
            {
                Console.WriteLine(helperMethod());
            }

            private string helperMethod()
            {
                return "Hello World";
            }
        }

    }
}
