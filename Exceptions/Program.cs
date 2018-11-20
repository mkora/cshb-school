using System;

namespace Exceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            /**
             * Common exceptions
             * The following table lists some common exceptions with examples of what can cause them.
             * 
             *  Exception type              Description                                 Example
             *  
             *  Exception                   Base class for all exceptions.              None (use a derived class of this exception).
             *  
             *  IndexOutOfRangeException    Thrown by the runtime only when an array    Indexing an array outside its valid range: 
             *                              is indexed improperly.                      arr[arr.Length+1]
             *                              
             *  NullReferenceException      Thrown by the runtime only when             object o = null; 
             *                              a null object is referenced.                o.ToString();
             *                              
             *  InvalidOperationException   Thrown by methods when in an invalid        Calling Enumerator.MoveNext() after removing
             *                              state.                                      an item from the underlying collection.
             *                              
             *  ArgumentException           Base class for all argument exceptions.     None (use a derived class of this exception).
             *  
             *  ArgumentNullException       Thrown by methods that do not allow         String s = null; 
             *                              an argument to be null.                     "Calculate".IndexOf(s);
             *                              
             *  ArgumentOutOfRangeException Thrown by methods that verify that          String s = "string"; 
             *                              arguments are in a given range.             s.Substring(s.Length+1);
             */
             
            int[] values = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            // Try / Catch Block

            try
            {
                // Example 1: Input values (null, -1)
                // GetValueAtIndex(null, -1);

                // Example 2: Input values (values, -1)
                // GetValueAtIndex(values, -1);

                // Example 3: Input values (values, 1)
                int val = GetValueAtIndex(values, 1);
                Console.WriteLine(val);

            }
            catch (NullReferenceException)
            {
                Console.WriteLine("An error occurred. Please, provide a not empty array");
            }
            catch (System.IndexOutOfRangeException)
            {
                Console.WriteLine("An error occurred. Please,"
                    + " provide an index value within 0 to {0} range", values.Length);
            }

            // Throwing Exceptions

            try
            {
                // Example 1: Input values (null ,-1)
                // GetValueAtIndexValid(null, -1);

                // Example 2: Input values (values, -1), index to small
                // GetValueAtIndexValid(values, -1);

                // Example 3: Input values (values, 50), index to large
                // GetValueAtIndexValid(values, 50);

                // Example 4: Input values (values, 1), index just fine
                int val = GetValueAtIndexValid(values, 1);
                Console.WriteLine(val);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            // Rethrowing Exceptions

            try
            {
                // Example 1: Input values (null ,-1)
                // GetValueAtIndexReThrowing(null, -1);

                // Example 2: Input values (values, -1), index to small
                // GetValueAtIndexReThrowing(values, -1);

                // Example 3: Input values (values, 50), index to large
                // GetValueAtIndexReThrowing(values, 50);

                // Example 4: Input values (values, 1), index just fine
                int val = GetValueAtIndexReThrowing(values, 1);
                Console.WriteLine(val);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }


            Console.ReadKey();
        }

        public static int GetValueAtIndex(int[] values, int index)
        {
            return values[index];
        }

        public static int GetValueAtIndexValid(int[] values, int index)
        {
            if (values == null)
            {
                throw new NullReferenceException("An error occurred."
                    + " Input array is empty. Please, provide a valid data");
            }

            if (index < 0 || index > values.Length)
            {
                throw new IndexOutOfRangeException("An error occurred. Index is out of range."
                    + " Please, provide a valid index from  0 to " + values.Length);
            }

            return values[index];
        }

        public static int GetValueAtIndexReThrowing(int[] values, int index)
        {
            Console.WriteLine("...Entering GetValueAtIndexValid...");
            try
            {
                if (values == null)
                {
                    throw new NullReferenceException("An error occurred."
                        + " Input array is empty. Please, provide a valid data");
                }

                if (index < 0 || index > values.Length)
                {
                    throw new IndexOutOfRangeException("An error occurred. Index is out of range."
                        + " Please, provide a valid index from  0 to " + values.Length);
                }

                return values[index];
            }
            catch (Exception e)
            {
                Console.WriteLine("...Error in GetValueAtIndex...");
                throw e;
            }
            finally
            {
                /** A finally block always executes, regardless of whether an exception is thrown.
                 *
                 * Some resource cleanup, such as closing a file, needs to be done
                 *   even if an exception is thrown.
                 */

            Console.WriteLine("...Exiting GetValueAtIndex...");
            }
        }
    }
}
