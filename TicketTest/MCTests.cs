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
    }
}