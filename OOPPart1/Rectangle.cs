using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPPart1
{
    public class Rectangle : Shape
    {
        public Point TopLeft { get; protected set; } // <-- auto-prop

        public double Width { get; protected set; } // <-- auto-prop

        public double Height { get; protected set; } // <-- auto-prop

        public override double Area // <-- overriden prop
        {
            get
            {
                return Width * Height;
            }
        }

        public Rectangle(Point topLeft, double width, double height)
        {
            Name = "Rectangle";

            TopLeft = topLeft;

            Width = width;

            Height = height;
        }

        public override bool Equals(Object obj) // <-- overrides Object.Equals
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
            var rect = obj as Rectangle;
            if (rect == null)
            {
                return false;
            }

            return TopLeft.Equals(rect.TopLeft) // <-- uses Point.Equals and double.Equals
                && Height.Equals(rect.Height)
                && Width.Equals(rect.Width);
        }
    }
}
