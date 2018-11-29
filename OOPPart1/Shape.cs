using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPPart1
{
    public class Shape
    {
        public string Name { get; protected set; } // <-- auto-prop

        public Shape() // <-- default constructor
        {
            Name = "Shape";
        }

        public virtual double Area // <-- vitual property to be ovverridden in a child class
        {
            get
            {
                throw new InvalidOperationException();
            }
            // no set method, Area only can be calculated
        }

        public override string ToString() // <-- overrides Object.ToString
        {
            return Name;
        }

    }
}
