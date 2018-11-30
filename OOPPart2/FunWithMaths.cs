using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AOOPPart2
{
    public class FunWithMaths
    {
        public int MultiplyNumbers(INumberProvider provider) // <-- uses different providers which implement one interface
        {
            int mult = 1;
            foreach (int i in provider.GetNumbers())
            {
                mult *= i;
            }
            return mult;
        }
    }
}
