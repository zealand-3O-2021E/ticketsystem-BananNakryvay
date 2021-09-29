using ClassLibraryTicketSystem;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace ClassLibraryTicketSystem.Tests
{
    [TestClass()]
    public class CarTests
    {
        [TestMethod()]
        public void PriceTest()
        {
            //Arrange  
            Car car = new Car();
            //Act  
            var expect = 240;
            //Assert
            Assert.AreEqual(expect, car.Price());
        }

        [TestMethod()]
        public void VehicleTypeTest()
        {
            //Arrange  
            Car car = new Car();
            //Act  
            var expect = "Car";
            //Assert
            Assert.AreEqual(expect, car.VehicleType());
        }
        [TestMethod()]
        public void LicensePlateTest()
        {
            Car car = new Car();

            //Act  
            car.Licenseplate = "1234567";
            var expect = 7;
            //Assert
            Assert.AreEqual(expect, car.Licenseplate.Length);
        }
        [TestMethod()]
        public void LicensePlateTestExeption()
        {
            Car car = new Car();
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => car.Licenseplate = "12345678");
        }


    }
}
