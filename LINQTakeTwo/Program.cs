using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq
{
    public class Program
    {
        static void Main(string[] args)
        {

            Console.ReadKey();
        }

        /**
         * Select & ToList
         * 
         */
        public static List<int> IncrementAll(List<int> data)
        {
            return data.Select(x => x + 1).ToList();
        }

        /**
         * Where & ToArray
         * 
         */
        public static int[] GetWhereDivisibleBy(List<int> data, int d)
        {
            return data.Where(x => x % d == 0).ToArray();
        }

        /**
         * Any
         * 
         */
        public static bool AnyCapitals(string data)
        {
            return data.Any(x => char.IsUpper(x));
        }

        /**
         * All
         * 
         */
        public static bool AllCapitals(string data)
        {
            return data.All(x => char.IsUpper(x) || char.IsWhiteSpace(x));
        }

        /**
         * Count
         * 
         */
        public static int NumPairs(Dictionary<int, string> data)
        {
            return data.Count();
        }

        /**
         * Count with Condition
         * 
         */
        public static int NumPairsWithKeyValue(Dictionary<int, string> data, int x, int y)
        {
            return data.Count(pair => pair.Key > x && pair.Value.Length < y);
        }

        /**
         * Where & Distinct
         * 
         */
        public static List<double> GetDistinctWithValue(List<double> data, int d)
        {
            return data.Where(x => x < d).Distinct().ToList();
        }

        /**
         * FirstOrDefault
         * 
         */
        public static int[] FindFirstArrayWithLength(List<int[]> data, int d)
        {
            return data.FirstOrDefault(x => x.Length > d);
        }

        /**
         * LastOrDefault
         *
         */
        public static int GetLastOddElement(int[] data)
        {
            return (int)data.LastOrDefault(x => x % 2 == 1);
        }

        /**
         * Max
         * 
         */
        public static int GetMaxStringLength(List<string> data)
        {
            return data.Max(x => x.Length);
        }

        /**
         * Min
         * 
         */
        public static int GetMinListListValue(List<List<int>> data)
        {
            return data.Min(x => x.Min());
        }

        /**
         * OfType and ToList
         * 
         * Filters the elements of an IEnumerable based on a specified type.
         * 
         */
        public static List<int> GetIntElements(List<object> data)
        {
            return data.OfType<int>().ToList();
        }

        /**
         * OrderBy() / OrderByDescending() / ThenBy()
         *
         */
        public static List<User> SortUsersByAge(List<User> data)
        {
            return data.OrderBy(x => x.Age).ThenBy(x => x.LastName).ToList();
        }

        /**
         * Reverse
         * 
         */
        public static string[] DoubleReverse(List<string> data)
        {
            return data.Select(x => {
                var arr = x.ToCharArray();
                Array.Reverse(arr);
                return string.Concat(arr);
            }).Reverse().ToArray();
        }


        /**
         * Sum
         * 
         */
        public static int Sum(List<int> data)
        {
            return data.Sum();
        }

        /**
         * Average
         * 
         */
        public static double Average(List<string> data)
        {
            return data.Average(x => x.Length);
        }

        /**
         * Take / Skip
         * 
         */
        public static List<int> TakeSkip(List<int> data, int take = 0, int skip = 0)
        {
            return data.Take(take).Skip(skip).ToList();
        }

        /**
         * Ultra LINQ
         * 
         * 
         */
        public static List<int> DoAllTheThings(List<int> nums, int max = Int32.MinValue, bool sort = false, int top = 0)
        {
            List<int> res = nums;
            return res = max != Int32.MinValue
                ? (
                    sort
                        ? (top != 0
                            ? res.Where(x => x <= max).OrderBy(x => x).Take(top).ToList()
                            : res.Where(x => x <= max).OrderBy(x => x).ToList()
                        )
                        : (top != 0
                            ? res.Where(x => x <= max).Take(top).ToList()
                            : res.Where(x => x <= max).ToList()
                        )
                  )
                : (
                    sort
                        ? (top != 0
                            ? res.OrderBy(x => x).Take(top).ToList()
                            : res.OrderBy(x => x).ToList()
                        )
                        : (top != 0
                            ? res.Take(top).ToList()
                            : res.ToList()
                        )
                  );
        }
    }

    public class User
    {
        public string FirstName;

        public string LastName;

        public int Age;
    }

}
