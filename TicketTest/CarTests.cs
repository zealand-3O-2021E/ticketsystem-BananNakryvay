using StoreBaeltTicketLibrary;
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
        [ExpectedException(typeof(ArgumentOutOfRangeException),"License Plate should be less than 7 chars")]
        public void LicensePlateTestExeption()
        {
            Car car = new Car();
            car.Licenseplate = "12345678";
        }

        [TestMethod()]
        public void PriceTestBrobizz()
        {
            //Arrange  
            Car car = new Car();
            //Act  
            car.Brobizz = true;
            var expect = 228;
            //Assert
            Assert.AreEqual(expect, car.Price(), 0.5d);
        }

      
    }
}
