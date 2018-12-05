using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPPart2
{
    public class WorkerBee : Employee // <-- inherits from abstract class
    {

        public WorkerBee(string Name) : base(Name) // <-- calls the base class constructor
        {
        }

        public override int GetSalary()
        {
            return 150;
        }
    }
}
