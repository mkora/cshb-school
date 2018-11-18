using System;

namespace SimpleMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            HelloWorld(); // interesting... no this.<method>, it's optional

            Console.ReadLine();
        }

        private static void HelloWorld()
        {
            Console.WriteLine("Hello World!");
        }
    }
}
