using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OOPPart1;

namespace OOPPart1.Test
{
    [TestClass]
    public class PointTests
    {

        [TestMethod]
        public void TestEqualsTrue()
        {
            var point1 = new Point(1.1, 2.2);
            var point2 = new Point(1.1, 2.2);

            Assert.IsTrue(point1.Equals(point2));
        }

        [TestMethod]
        public void TestEqualsFalse()
        {
            var point1 = new Point(1.1, 2.2);
            var point2 = new Point(2.2, 1.1);

            Assert.IsFalse(point1.Equals(point2));
        }
    }
}
