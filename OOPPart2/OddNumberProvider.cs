using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPPart2
{
    public class OddNumberProvider : INumberProvider // <-- implement interface
    {
        public int[] GetNumbers()
        {
            return new int[] { 1, 3, 5, 7, 9 };
        }
    }
}
