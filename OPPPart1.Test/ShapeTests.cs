using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OOPPart1;

namespace OOPPart1.Test
{

    [TestClass]
    public class ShapeTests
    {

        [TestMethod]
        public void TestToString()
        {
            var expectedOutput = "Shape";

            var shape = new Shape();

            Assert.AreEqual(shape.ToString(), expectedOutput);
        }
    }
}
