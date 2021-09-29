using ClassLibraryTicketSystem;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OresundBron;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OresundBron.Tests
{
    [TestClass()]
    public class OresundBronTests
    {
        public void CarPriceTest()
        {
            //Arrange  
            Vehicle car = new OresundBronCar();
            //Act  
            var expect = 410;
            //Assert
            Assert.AreEqual(expect, car.Price());
        }

        public void CarBrobizzPriceTest()
        {
            //Arrange  
            Vehicle car = new OresundBronCar();
            //Act  
            car.Brobizz = true;
            var expect = 161;
            //Assert
            Assert.AreEqual(expect, car.Price());
        }

        [TestMethod()]
        public void CarVehicleTypeTest()
        {
            //Arrange  
            Vehicle car = new OresundBronCar();
            //Act  
            var expect = "Oresund Car";
            //Assert
            Assert.AreEqual(expect, car.VehicleType());
        }
        [TestMethod()]
        public void MCPriceTest()
        {
            //Arrange  
            Vehicle mc = new OresundBronMC();
            //Act  
            var expect = 210;
            //Assert
            Assert.AreEqual(expect, mc.Price());
        }
        [TestMethod()]
        public void BrobizzMCPriceTest()
        {
            //Arrange  
            Vehicle mc = new OresundBronMC();
            //Act  
            mc.Brobizz = true;
            var expect = 73;
            //Assert
            Assert.AreEqual(expect, mc.Price());
        }


        [TestMethod()]
        public void MCVehicleTypeTest()
        {
            //Arrange  
            Vehicle mc = new OresundBronMC();
            //Act  
            var expect = "Oresund MC";
            //Assert
            Assert.AreEqual(expect, mc.VehicleType());
        }
    }
}