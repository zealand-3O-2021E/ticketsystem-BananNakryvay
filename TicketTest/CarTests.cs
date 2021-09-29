using ClassLibraryTicketSystem;
using Microsoft.VisualStudio.TestTools.UnitTesting;

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
    }
}
