using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            /**
             * Collection classes serve various purposes, such as allocating memory dynamically
             * to elementsand accessing a list of items on the basis of an index etc.
             *
             *  
             *  1. System.Collectionsc Classes (old style collections)
             * 
             *  Class                       Description
             *  
             *  ArrayList                   Represents an array of objects whose size is dynamically increased as required.
             *  
             *  Hashtable                   Represents a collection of key/value pairs that are organized 
             *                              based on the hash code of the key.
             *  Queue                       Represents a first in, first out (FIFO) collection of objects.
             *  
             *  Stack                       Represents a last in, first out (LIFO) collection of objects.
             *  
             *  2. System.Collections.Generic Classes
             *  
             *  Class                       Description
             *  
             *  Dictionary<TKey,TValue>     Represents a collection of key/value pairs that are organized based on the key.
             *  
             *  List<T>                     Represents a list of objects that can be accessed by index. 
             *                              Provides methods to search, sort, and modify lists.
             *  Queue<T>                    Represents a first in, first out (FIFO) collection of objects.
             *  
             *  SortedList<TKey,TValue>     Represents a collection of key/value pairs that are sorted by key 
             *                              based on the associated IComparer<T> implementation.
             *  Stack<T>                    Represents a last in, first out (LIFO) collection of objects.
             *  
             *  3. System.Collections.Concurrent Classes
             *  
             *  In the .NET Framework 4 or newer, the collections in the System.Collections.Concurrent namespace 
             *  provide efficient thread-safe operations for accessing collection items from multiple threads.
             *  
             *  
             *  https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/concepts/collections
             */

            /**
             * LINQ: .NET Language-Integrated Query
             * 
             * LINQ extends the language by the addition of query expressions,
             * which are akin to SQL statements, and can be used to conveniently extract and process data from
             * arrays, enumerable classes, XML documents, relational databases, and third-party data sources.
             */

            Car car1 = new Car();
            car1.Make = "Oldsmodile";
            car1.Model = "Cutlas Supreme";
            car1.VIN = "A1";

            Car car2 = new Car();
            car2.Make = "Geo";
            car2.Model = "Prism";
            car2.VIN = "D4";

            Book book1 = new Book();
            book1.Title = "Microsoft .NET XML Web Services";
            book1.Author = "Robert Tabor";
            book1.ISBN = "0-000-0000-0";

            // ArrayLists are dynamically sized, supports many features 
            // like sorting, removing element and so on.

            ArrayList myArrayList = new ArrayList();
            myArrayList.Add(car1);
            myArrayList.Add(car2);
            myArrayList.Add(book1);
            myArrayList.Remove(book1);

            // Downside: No way to limit type of data
            foreach (Car car in myArrayList)
            {
                Console.WriteLine(car.Model); // fail if the book in the collection
            }

            // Generic List (type-specified)
            List<Car> myList = new List<Car>();
            myList.Add(car1);
            myList.Add(car2);

            foreach (Car car in myList)
            {
                Console.WriteLine(car.Model); // fail if the book in the collection
            }

            // Dictionary<TKey, TValue>
            Dictionary<string, Car> myDictionary = new Dictionary<string, Car>();
            myDictionary.Add(car1.VIN, car1);
            myDictionary.Add(car2.VIN, car2);

            Console.WriteLine(myDictionary["A1"].Model);

            // Object Initiolizer
            string[] names = { "Bob", "Steve", "Brian", "Chuk" };

            Car car3 = new Car() { Make = "BMV", Model = "750li", VIN = "B2" }; // no need for a constructor
            Car car4 = new Car() { Make = "Toyota", Model = "4Runner", VIN = "C3" };

            // Collection initiolizer: List
            List<Car> myNewList = new List<Car>()
            {
                new Car() {  Make = "Oldsmodile", Model = "Cutlas Supreme", VIN = "A2" },
                new Car() {  Make = "Geo", Model = "Prism", VIN = "D5" },
            };

            foreach (Car car in myNewList)
            {
                Console.WriteLine(car.VIN);
            }

            Console.ReadLine();

            // Collection initiolizer: Dictionary
            Dictionary<string, Car> myNewDictionary = new Dictionary<string, Car>()
            {
                { "A3",
                    new Car() {  Make = "Oldsmodile", Model = "Cutlas Supreme", VIN = "A3" }},
                { "D6",
                    new Car() {  Make = "Geo", Model = "Prism", VIN = "D6" }}
            };

            Console.WriteLine(myDictionary["A3"].Model);
        }
    }

    class Car
    {
        public string VIN { get; set; }

        public string Make { get; set; }

        public string Model { get; set; }
    }

    class Book
    {
        public string Title { get; set; }

        public string Author { get; set; }

        public string ISBN { get; set; }
    }
}
