using System;

namespace ForIteration
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 10; i++)
            {
                //Console.WriteLine(i);
                if (i == 7)
                {
                    Console.WriteLine("Found seven!");
                    break;
                }
            }
            Console.ReadLine();
        }
    }
}