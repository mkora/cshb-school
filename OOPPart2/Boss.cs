using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPPart2
{
    public class Boss : Employee
    {

        public Boss(string Name) : base(Name) // <-- calls the base class constructor
        {
        }

        public override int GetSalary()
        {
            return 1000;
        }
    }
}
