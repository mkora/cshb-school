using MyClassLibrary;
using System;
using System.IO; // to use File.<method>. Alternativly, you can use just System.IO.File.WriteAllText
using System.Net;

namespace AssemliesNNamespaces
{
    class Program
    {
        static void Main(string[] args)
        {
            /**
             * Assemblies form the fundamental unit of deployment, version control, reuse,
             * activation scoping, and security permissions for a .NET-based application.
             * 
             * Assemblies take the form of an executable (.exe) file or dynamic link library
             * (.dll) file, and are the building blocks of the .NET Framework.
             * They provide the common language runtime with the information it needs
             * to be aware of type implementations. 
             * 
             * You can think of an assembly as a collection of types and resources 
             * that form a logical unit of functionality and are built to work together.
             */


            // Example 1:
            // site:microsoft.com write to text file c#
            string text = "A class is the most powerful data type in C#. Like a structure, " +
                           "a class defines the data and behavior of the data type. ";
            File.WriteAllText(@"C:\code\cshb-school\tmp\WriteText1.txt", text);

            Console.WriteLine("Writing to a text file... Done");


            // Example 2:
            // sites:microsoft.com c# download html string
            WebClient client = new WebClient();
            string reply = client.DownloadString("https://docs.microsoft.com");
            File.WriteAllText(@"C:\code\cshb-school\tmp\WriteText2.txt", reply);
            Console.WriteLine("Writing to a text file... Done");

            // Add a new References to a project:

            // Example 3:
            // Add a new Reference to our project
            // Solution Explorer -> Dependencies -> Add Reference -> ...

            // Example 4:
            /** NuGet is the package manager for .NET.
             * 
             * The NuGet client tools provide the ability to produce and consume packages.
             * The NuGet Gallery is the central package repository used by all package authors and consumers. 
             */
            // Tools -> NuGet Package Manager -> Manage NuGet Packages for Solution
            // And install Entity Framework, or Boorstrap,  and etc!

            // Example 4:
            // Create a reusable library
            // Create a new project and a Class (in this case MyClassLibrary)
            // Add a new reference (see Example 3)

            Scrape myScrape = new Scrape();

            string value = myScrape.ScrapeWebPage("https://docs.microsoft.com");
            Console.WriteLine(value);

            Console.ReadLine();
        }
    }
}
