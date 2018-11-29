using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPPart1
{
    public class Point
    {
        public double X { get; protected set; } // <-- auto-properties

        public double Y { get; protected set; } // <-- auto-properties

        public Point(double x, double y)
        {
            X = x;
            Y = y;
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
            var point = obj as Point;
            if (point == null)
            {
                return false;
            }

            return X.Equals(point.X) && Y.Equals(point.Y); // <-- uses double.Equals
        }
    }

}
