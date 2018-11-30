using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPPart2
{
    public class EvenNumberProvider : INumberProvider // <-- implement interface
    {
        public int[] GetNumbers()
        {
            return new int[] { 2, 4, 6, 8, 10 };
        }
    }
}
