using System;

namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string str;

            // Escape Character
            str = "My \"so-called\" life";
            Console.WriteLine(str);

            str = "What if I need a \nnew line?";
            Console.WriteLine(str);

            str = "Go to your C:\\ drive";
            Console.WriteLine(str);

            str = @"Go to your C:\ drive";
            Console.WriteLine(str);


            // Special Formats
            /**
             * Find more here:
             * https://docs.microsoft.com/en-us/dotnet/standard/base-types/standard-numeric-format-strings
             * 
             */
            str = String.Format("{0} = {1} = {0}", "First", "Second");
            Console.WriteLine(str);

            str = String.Format("Price: {0:C}", 123.45); // currency
            Console.WriteLine(str);

            str = String.Format("{0:N}", 1234567890); // big number
            Console.WriteLine(str);

            str = String.Format("Percentage: {0:P1}", .123); // percent
            Console.WriteLine(str);

            str = String.Format("Phone: {0:(###) ###-####}", 1234567890); // custom format (tel numbers)
            Console.WriteLine(str);


            // Build-in Methods
            string tpl = " That summer we took threes across the board  ";

            str = tpl.Trim();
            Console.WriteLine(str);

            str = tpl.Substring(5, 14); // start from 6th char and returns 14 chars
            Console.WriteLine(str);

            str = tpl.ToUpper();
            Console.WriteLine(str);

            str = tpl.Replace(" ", "--");
            Console.WriteLine(str);

            str = tpl.Remove(6, 14);
            Console.WriteLine(str);

            // Strings are immutable
            str = "";
            for (int i = 0; i < 10; i++)
            {
                str += "--" + i.ToString(); // Concat
            }
            Console.WriteLine(str);

            // Alturnative way is to use StringBuilder
            //StringBuilder strBuilder = new StringBuilder();
            //for (int i = 0; i < 10; i++)
            //{
            //    strBuilder.Append("--");
            //    strBuilder.Append(i.ToString())); // Concat
            //}
        }
    }
}
