using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPPart2
{
    public interface INumberProvider // <-- interface
    {
        int[] GetNumbers(); // <-- always public (no access modifiers for intrfaces)
    }
}
