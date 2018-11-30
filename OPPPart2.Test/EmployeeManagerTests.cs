using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace OOPPart2.Test
{
    [TestClass]
    public class EmployeeManagerTests
    {
        [TestMethod]
        public void TestGetTotalSalary()
        {
            var expectedSalary = 1300;

            var em = new EmployeeManager();
            Employee[] arr = {
                new WorkerBee("A"),
                new WorkerBee("B"),
                new Boss("C")
            };

            Assert.AreEqual(em.GetTotalSalary(arr), expectedSalary);
        }
    }
}
