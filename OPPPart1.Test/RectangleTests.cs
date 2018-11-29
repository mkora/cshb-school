using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OOPPart1;

namespace OOPPart1.Test
{

    [TestClass]
    public class RectangleTests
    {

        [TestMethod]
        public void TestInit()
        {
            var expectedName = "Rectangle";

            var rec = new Rectangle(new Point(1, 2), 2, 3);

            Assert.AreEqual(rec.Name, expectedName);
        }

        [TestMethod]
        public void TestGetArea()
        {
            double expectedArea = 6;

            var rec = new Rectangle(new Point(1, 2), 2, 3);

            Assert.AreEqual(rec.Area, expectedArea);
        }

        [TestMethod]
        public void TestToString()
        {
            var expectedOutput = "Rectangle";

            var rec = new Rectangle(new Point(1, 2), 2, 3);

            Assert.AreEqual(rec.ToString(), expectedOutput);
        }

        [TestMethod]
        public void TestEqualsTrue()
        {
            var rect1 = new Rectangle(new Point(1.1, 2.2), 3, 4);
            var rect2 = new Rectangle(new Point(1.1, 2.2), 3, 4);

            Assert.IsTrue(rect1.Equals(rect2));
        }

        [TestMethod]
        public void TestEqualsFalse()
        {
            var rect1 = new Rectangle(new Point(1.1, 2.2), 3, 4);
            var rect2 = new Rectangle(new Point(2.2, 3.3), 4, 1);

            Assert.IsFalse(rect1.Equals(rect2));
        }
    }
}
