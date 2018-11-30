using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace OOPPart2.Test
{
    [TestClass]
    public class FunWithMathsTests
    {
        [TestMethod]
        public void TestMultiplyEvenNumbers()
        {

            var fm = new FunWithMaths();
            int expectedOut = 3840;
                
            Assert.AreEqual(fm.MultiplyNumbers(new EvenNumberProvider()), expectedOut);
        }

        [TestMethod]
        public void TestMultiplyOddNumbers()
        {

            var fm = new FunWithMaths();
            int expectedOut = 945;

            Assert.AreEqual(fm.MultiplyNumbers(new OddNumberProvider()), expectedOut);
        }

        [TestMethod]
        public void TestMultiplyMockNumbers()
        {

            var fm = new FunWithMaths();
            int expectedOut = 6;

            Assert.AreEqual(fm.MultiplyNumbers(new MockNumberProvider()), expectedOut);
        }
    }
}
