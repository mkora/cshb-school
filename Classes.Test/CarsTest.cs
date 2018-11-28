using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Classes;

namespace Classes.Test
{
    [TestClass]
    public class CarTests
    {
        [TestMethod]
        public void TestDefaultInit()
        {

            var make = "";
            var model = "";
            var year = 2018;
            var mileage = 0.00;

            var car = new Car();

            Assert.AreEqual(car.Make, make);
            Assert.AreEqual(car.Model, model);
            Assert.AreEqual(car.Year, year);
            Assert.AreEqual(car.Mileage, mileage);
            Assert.IsNotNull(car.OwnerHistory);

        }

        [TestMethod]
        public void TestInit()
        {

            var make = "Test Make";
            var model = "Test Model";
            var year = 2000;
            var mileage = 2000.00;

            var car = new Car(make, model, year, mileage);

            Assert.AreEqual(car.Make, make);
            Assert.AreEqual(car.Model, model);
            Assert.AreEqual(car.Year, year);
            Assert.AreEqual(car.Mileage, mileage);
            Assert.IsNotNull(car.OwnerHistory);
        }

        [TestMethod]

        public void TestAddMiles()
        {
            var expectedMiles = 199.00;

            var car = new Car();
            car.AddMiles(expectedMiles);

            Assert.AreEqual(car.Mileage, expectedMiles);
        }


        [TestMethod]

        [ExpectedException(typeof(ArgumentOutOfRangeException))]

        public void TestAddNegativeMiles()
        {
            var expectedMiles = -199.00;

            var car = new Car();
            car.AddMiles(expectedMiles);

        }

        [TestMethod]
        public void TestGetNumWheels()
        {
            var expectedNumWheels = 4;

            Assert.AreEqual(Car.GetNumWheels(), expectedNumWheels);

        }
    }
}
