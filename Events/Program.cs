using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace Events
{
    class Program
    {
        static void Main(string[] args)
        {
            /**
             * An event handler, in C#, is a method that contains the code that gets executed
             * in response to a specific event that occurs in an application. 
             * 
             * Event handlers are used in graphical user interface (GUI) applications to handle 
             * events such as button clicks and menu selections, raised by controls in the user interface.
             * 
             * Guide:
             * https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/events/
             */

            // interval in millisecods we want an elapsed event to be rased
            Timer myTimer = new Timer(2000);

            myTimer.Elapsed += MyTimer_Elapsed; // press tab to create a signature of this method

            myTimer.Elapsed += MyTimer_Elapsed1;

            myTimer.Start();

            Console.WriteLine("Press Enter to remove the red event");
            Console.ReadLine();

            myTimer.Elapsed -= MyTimer_Elapsed1;


            // continue runnig until someone hits enter on a keybord
            Console.ReadLine();
        }

        private static void MyTimer_Elapsed(object sender, ElapsedEventArgs e)
        {
            Console.ForegroundColor = ConsoleColor.White;
            // SignalTime - when this event was rased
            Console.WriteLine("Elapsed: {0:HH:mm:ss.fff}", e.SignalTime);
        }

        private static void MyTimer_Elapsed1(object sender, ElapsedEventArgs e)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Elapsed1: {0:HH:mm:ss.fff}", e.SignalTime);
        }
    }
}
