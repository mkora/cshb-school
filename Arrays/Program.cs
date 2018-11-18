using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            // Array decloration

            // First approach
            int[] numbers = new int[5];

            numbers[0] = 4;
            numbers[1] = 8;
            numbers[2] = 15;
            numbers[3] = 16;
            numbers[4] = 23;

            Console.WriteLine("Second element of the array is {0}", numbers[1]);
            Console.WriteLine("The length of the array is {0}", numbers.Length);

            // Second approach
            int[] otherNumbers = new int[] { 4, 8, 15, 16, 23, 42 };

            string[] names = new string[] { "Eddie", "Alex", "Michael", "David" };

            // Looping through

            // First method: For-loop
            Console.WriteLine("Looping #1:");
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(numbers[i]);
            }

            // Second method: Foreach
            Console.WriteLine("Looping #2:");
            foreach (string name in names)
            {
                Console.WriteLine(name);
            }

            // Reverse string (`build-in methods` approach)
            string zig = "You can get what you want out of life if you help " 
                + "enough other people get what they want.";
            Console.WriteLine("Reverse String: {0}", zig);

            char[] charArray = zig.ToCharArray();
            Array.Reverse(charArray);

            Console.Write("Reversed: ");
            foreach (char ch in charArray)
            {
                Console.Write(ch);
            }
            Console.ReadLine();
        }
    }
}
