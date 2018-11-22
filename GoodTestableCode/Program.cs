using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace GoodTestableCode
{
    class Program
    {
        static void Main(string[] args)
        {

            C1 c1 = new C1();
            C2 c2 = new C2();
            C3 c3 = new C3();

            // Constructor injection
            C4 ExampleClass1 = new C4(c1, c2, c3);
            ExampleClass1.DoStuff();

            // Method injection
            C5 ExampleClass2 = new C5();
            ExampleClass2.DoStuff(c1, c2, c3);

            Console.ReadKey();
        }

        public class C1
        {
            public void DoStuff() { }
        }

        public class C2
        {
            public void DoStuff() { }
        }

        public class C3
        {
            public void DoStuff() { }
        }

        // constructor injection
        public class C4
        {
            private C1 c1;
            private C2 c2;
            private C3 c3;

            public C4(C1 first, C2 second, C3 third)
            {
                c1 = first;
                c2 = second;
                c3 = third;
            }

            public void DoStuff()
            {
                c1.DoStuff();
                c2.DoStuff();
                c3.DoStuff();
            }
        }

        // method injection
        public class C5
        {
            private C1 c1;
            private C2 c2;
            private C3 c3;

            public void DoStuff(C1 first, C2 second, C3 third)
            {
                c1 = first;
                c2 = second;
                c3 = third;

                c1.DoStuff();
                c2.DoStuff();
                c3.DoStuff();
            }
        }
    }
}
