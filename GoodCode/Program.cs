using System;
using System.Collections.Generic;
using System.Threading;
using System.Configuration;

namespace GoodCode
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calling GetFirstMatchingIndex...");
            List<int> vals = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            int res = GetFirstMatchingIndex(vals, 5);
            Console.WriteLine(res);

            Console.WriteLine("Calling DoStuff...");
            DoStuff();

            Console.ReadKey();

        }

        // Inverting Conditionals and Early Returns

        /* Input */
        /*
        public static int GetFirstMatchingIndex(List<int> nums, int valueToMatch)
        {
            int matchingIndex = -1;

            if (nums != null)
            {
                if (nums.Count > 0)
                {
                    for (var i = 0; i < nums.Count; i++)
                    {
                        if (nums[i] == valueToMatch)
                        {
                            matchingIndex = i;
                            break;
                        }
                    }
                }
            }

            return matchingIndex;
        }
        */

        /* Result */
        public static int GetFirstMatchingIndex(List<int> nums, int valueToMatch)
        {
            if (nums == null || nums.Count == 0)
            {
                return -1;
            }

            for (var i = 0; i < nums.Count; i++)
            {
                if (nums[i] == valueToMatch)
                {
                    return i;
                }
            }

            return -1;
        }


        // Using Constants & Configuration Manager

        /* Input */
        /*
        public static void DoStuff()
        {
            Console.WriteLine("Hello Cohort!");
            Thread.Sleep(2000);

            var jobTypes = new string[] { "PM", "Dev", "Other" };
            Console.WriteLine("The job types are:");
            foreach (var type in jobTypes)
                Console.WriteLine(type);

            Console.WriteLine("Goodbye Cohort!");
        }
        */

        /* Result */
        /** 
         * 1. A little more on storing configuration in Settings files: 
         * 
         * https://docs.microsoft.com/en-us/dotnet/api/system.configuration.configurationmanager?redirectedfrom=MSDN&view=netframework-4.7.2
         *
         * 2. Enums:
         * 
         *  An enumeration type (also named an enumeration or an enum) 
         *  provides an efficient way to define a set of named integral constants that may be assigned to a variable.
         *  The approved types for an enum are byte, sbyte, short, ushort, int, uint, long, or ulong.
         *   
         *  By default the underlying type of each element in the enum is int.
         *      
         *      enum Day { Sunday, Monday, Tuesday, Wednesday, Thursday, Friday, Saturday };
         *      enum Month : byte { Jan, Feb, Mar, Apr, May, Jun, Jul, Aug, Sep, Oct, Nov, Dec }; 
         * 
         *  You can use an enumeration type to define bit flags, which enables an instance of the enumeration type 
         *  to store any combination of the values that are defined in the enumerator list. 
         * 
         *      [Flags]
         *       enum Days
         *       {
         *           None = 0x0,
         *           Sunday = 0x1,
         *           Monday = 0x2,
         *           Tuesday = 0x4,
         *           Wednesday = 0x8,
         *           Thursday = 0x10,
         *           Friday = 0x20,
         *           Saturday = 0x40
         *       }
         *       class MyClass
         *       {
         *           Days meetingDays = Days.Tuesday | Days.Thursday;
         *
         *           // Console.WriteLine("Meeting days are {0}", meetingDays);
         *           // Output: Meeting days are Tuesday, Thursday
         *       }  
         * 
         * https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/enumeration-types
         *
         * 3. Iterate through dictionary:
         * 
         *      foreach(KeyValuePair<string, string> entry in myDictionary)
         *      {
         *          // do something with entry.Value or entry.Key
         *      }
         *      
         * Source:
         * https://stackoverflow.com/questions/141088/what-is-the-best-way-to-iterate-over-a-dictionary
         * 
         */

        enum Position { PM, Dev, Other }

        public static void DoStuff()
        {

            const int timeToSleep = 2000;

            string greeting = ReadSetting("greeting"); // do we actully need to do this for these strings?!
            string farewell = ReadSetting("farewell");
            string description = ReadSetting("description");

            Dictionary<int, string> jobTypes = new Dictionary<int, string>()
            {
                { (int)Position.PM, "PM" },
                { (int)Position.Dev, "Dev" },
                { (int)Position.Other, "Other" }
            };

            Console.WriteLine(greeting);
            Thread.Sleep(timeToSleep);

            Console.WriteLine(description);

            foreach (KeyValuePair<int, string> type in jobTypes)
                Console.WriteLine(type.Value); // also there is a type.Key

            Console.WriteLine(farewell);
        }

        static string ReadSetting(string key)
        {
            var appSettings = ConfigurationManager.AppSettings;
            string result = appSettings[key] ?? "Not Found";
            return result;
        }
    }
}
