using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OOPPart1;

namespace OOPPart1.Test
{

    [TestClass]
    public class CircleTests
    {

        [TestMethod]
        public void TestInit()
        {
            var expectedName = "Circle";
            var expectedCenter = new Point(0, 0);

            double expectedRadiusDouble = 2;

            var circle1 = new Circle(expectedCenter, expectedRadiusDouble);
            Assert.AreEqual(circle1.Name, expectedName);
            Assert.AreEqual(circle1.Radius, expectedRadiusDouble);
            Assert.AreEqual(circle1.Center, expectedCenter);

            float expectedRadiusFloat = 2;

            var circle2 = new Circle(expectedCenter, expectedRadiusFloat);
            Assert.AreEqual(circle2.Name, expectedName);
            Assert.AreEqual(circle2.Radius, expectedRadiusFloat);
            Assert.AreEqual(circle2.Center, expectedCenter);

            int expectedRadiusInt = 2;

            var circle3 = new Circle(expectedCenter, expectedRadiusInt);
            Assert.AreEqual(circle3.Name, expectedName);
            Assert.AreEqual(circle3.Radius, expectedRadiusInt);
            Assert.AreEqual(circle3.Center, expectedCenter);

            var circle4 = new Circle(expectedRadiusDouble);
            Assert.AreEqual(circle4.Name, expectedName);
            Assert.AreEqual(circle4.Radius, expectedRadiusDouble);
            Assert.AreEqual(circle4.Center, expectedCenter);
        }

        [TestMethod]
        public void TestGetArea()
        {
            double expectedArea = 12.5663706143592;

            var circle = new Circle(new Point(1, 2), 2);

            /**
             * Because of double data type (for float don't need to)
             * use delta (the third parameter in asserts) to check if two values are equal
             */
            Assert.AreEqual(circle.Area, expectedArea, 0.00000000001);
        }

        [TestMethod]
        public void TestToString()
        {
            var expectedOutput = "Circle";

            var circle = new Circle(new Point(1, 2), 2);

            Assert.AreEqual(circle.ToString(), expectedOutput);
        }

        [TestMethod]
        public void TestEqualsTrue()
        {
            var circle1 = new Circle(new Point(1.1, 2.2), 3);
            var circle2 = new Circle(new Point(1.1, 2.2), 3);

            Assert.IsTrue(circle1.Equals(circle2));
        }

        [TestMethod]
        public void TestEqualsFalse()
        {
            var circle1 = new Circle(new Point(1.1, 2.2), 3);
            var circle2 = new Circle(new Point(2.2, 3.3), 1);

            Assert.IsFalse(circle1.Equals(circle2));
        }
    }
}
