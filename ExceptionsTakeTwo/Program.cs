using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace HandlingExceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string contents = File.ReadAllText("Example.txt");
                Console.WriteLine(contents);

            }
            catch (FileNotFoundException e)
            {
                Console.WriteLine("There was a problem!");
                Console.WriteLine("Make sure the name of the file is name correctly: Example.txt");
            }
            catch (Exception e)
            {

                Console.WriteLine("There was a problem!");
                Console.WriteLine(e.Message);
            }
            finally
            {
                // code to finalize 
                // setting objects to null
                // closing db connections
                Console.WriteLine("Closing the application now... ");
            }

            Console.ReadKey();
        }
    }
}
