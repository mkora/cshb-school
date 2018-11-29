using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPPart1
{
    public class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Area of (2 x 4) rectangle is {0}",
                GetShapeArea(new Rectangle(new Point(1, 1), 2, 4))
            );

            Console.WriteLine("Area of (2 x 2) square is {0}",
                GetShapeArea(new Square(new Point(1, 1), 2))
            );

            Console.WriteLine("Area of (r = 2) circle is {0}",
                GetShapeArea(new Circle(new Point(1, 1), 2))
            );


            Console.ReadKey();
        }

        // Polymorphism 2 : Subtyping

        public static double GetShapeArea(Shape shape)
        {
            return shape.Area;
        }
    }
}
