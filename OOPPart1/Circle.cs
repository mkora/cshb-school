using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPPart1
{
    public class Circle : Shape
    {
        public Point Center { get; protected set; } // <-- auto-prop

        public double Radius { get; protected set; } // <-- auto-prop

        public override double Area { // <-- overriden prop
            get
            {
                return Math.PI * Radius * Radius;
            }
            // no set method, Area only can be calculated
        }

        public Circle(Point p, double radius)
        {
            Name = "Circle";

            Center = p;

            Radius = radius;
        }

        // Polymorphism 1 : Function Overloading

        public Circle(Point p, float radius) : this(p, (double)radius) // <-- constructor chaining & function overloading
        {
        }

        public Circle(Point p, int radius) : this(p, (double)radius) // <-- constructor chaining & function overloading
        {
        }
   
        public Circle(double radius) : this(new Point(0, 0), (double)radius) // <-- constructor chaining & function overloading
        {
        }

        public override bool Equals(Object obj)  // <-- overrides Object.Equals
        {
            /**
             * You can use the AS operator to perform certain types of conversions
             * between compatible reference types or nullable types.
             * 
             * Preferably, use IS for bool expressions: <expr> is <type>.
             * 
             * IS checks if an object is compatible with a given type, or
             * (starting with C# 7.0) tests an expression against a pattern.
             * 
             * Example:
             *  if (obj is Person) {
             *      // Do something if obj is a Person.
             *  }
             */
            var circle = obj as Circle;
            if (circle == null)
            {
                return false;
            }

            return Center.Equals(circle.Center)  // <-- uses Point.Equals and double.Equals
                && Radius.Equals(circle.Radius);
        }
    }
}
