using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPPart2
{
    public abstract class Employee // <-- abstract class
    {

        public string Name { get; private set; }

        public Employee(string name)
        {
            Name = name;
        }

        public abstract int GetSalary(); // <-- abstract method

    }
}
