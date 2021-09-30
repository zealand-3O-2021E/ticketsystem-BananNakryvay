using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibraryTicketSystem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryTicketSystem.Tests
{
    [TestClass()]
    public class MCTests
    {
        [TestMethod()]
        public void PriceTest()
        {
            //Arrange  
            MC mc = new MC();
            //Act  
            var expect = 125;
            //Assert
            Assert.AreEqual(expect, mc.Price());
        }

        [TestMethod()]
        public void VehicleTypeTest()
        {
            //Arrange  
            MC mc = new MC();
            //Act  
            var expect = "MC";
            //Assert
            Assert.AreEqual(expect, mc.VehicleType());
        }

        [TestMethod()]
        public void LicensePlateTest()
        {
            MC mc = new MC();

            //Act  
            mc.Licenseplate = "1234567";
            var expect = 7;
            //Assert
            Assert.AreEqual(expect, mc.Licenseplate.Length);
        }
    
        [TestMethod()]
        [ExpectedException(typeof(ArgumentOutOfRangeException), "License Plate should be less than 7 chars")]
        public void LicensePlateTestExeption()
        {
            MC mc = new MC();
            mc.Licenseplate = "12345678";
        }
        [TestMethod()]
        public void PriceTestBrobizz()
        {
            //Arrange  
            MC mc = new MC();
            //Act  
            mc.Brobizz = true;
            var expect = 118.75;
            //Assert
            Assert.AreEqual(expect, mc.Price(), 0.5d);
        }
    }
}