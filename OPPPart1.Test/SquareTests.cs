using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OOPPart1;

namespace OOPPart1.Test
{
    [TestClass]
    public class SquareTests
    {

        [TestMethod]
        public void TestInit()
        {
            var expectedName = "Square";

            var square = new Square(new Point(1, 2), 2);

            Assert.AreEqual(square.Name, expectedName);
        }

        [TestMethod]
        public void TestGetArea()
        {
            double expectedArea = 4;

            var square = new Square(new Point(1, 2), 2);

            Assert.AreEqual(square.Area, expectedArea);
        }

        [TestMethod]
        public void TestToString()
        {
            var expectedOutput = "Square";

            var square = new Square(new Point(1, 2), 2);

            Assert.AreEqual(square.ToString(), expectedOutput);
        }

        [TestMethod]
        public void TestEqualsTrue()
        {
            var square1 = new Square(new Point(1.1, 2.2), 3);
            var square2 = new Square(new Point(1.1, 2.2), 3);

            Assert.IsTrue(square1.Equals(square2));
        }

        [TestMethod]
        public void TestEqualsFalse()
        {
            var square1 = new Square(new Point(1.1, 2.2), 3);
            var square2 = new Square(new Point(2.2, 3.3), 1);

            Assert.IsFalse(square1.Equals(square2));
        }
    }
}
