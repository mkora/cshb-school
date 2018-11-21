using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTests
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[] vals1 = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            int res1 = SumArray(vals1);
            Console.WriteLine(res1);

            int[] vals2 = { 1, 2, 3, 4, 5 };
            int res2 = SumArray(vals2);
            Console.WriteLine(res2);

            Console.ReadKey();
        }

        public static int SumArray(int[] values)
        {
            var sum = 0;

            if (values == null || values.Length == 0)
            {
                return sum;
            }
            foreach (var value in values)
            {
                sum += value;
            }
            return sum;
        }

        public static int GetValueAtIndex(int[] values, int index)
        {
            if (values == null)
            {
                throw new ArgumentNullException("values");
            }
            if (index < 0 || index > values.Length - 1)
            {
                throw new ArgumentOutOfRangeException();
            }
            return values[index];
        }


    }
}
