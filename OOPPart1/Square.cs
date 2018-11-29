using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPPart1
{
    public class Square : Rectangle // <-- inherited from Rectangle which inherits from Shape (transitive inheritance)
    {
        public Square(Point topLeft, double length) :
            base(topLeft, length, length) // <-- calls the base (Rectangle) constructor
        {
            Name = "Square";
        }

    }
}
