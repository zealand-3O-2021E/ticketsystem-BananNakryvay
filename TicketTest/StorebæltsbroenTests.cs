using ClassLibraryTicketSystem;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using StoreBaeltTicketLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreBaeltTicketLibrary.Tests
{
    [TestClass()]
    public class StorebæltsbroenTests
    {
        [TestMethod()]
        public void DiscountTestCar()
        {
            //Arrange  
            Car car = new Car();
            //Act  
            car.Brobizz = true;
            car.Date = new DateTime(2021, 10, 3);
            var actual = Discount.GetDiscount(car);
            var expect = 182.4;
            //Assert
            Assert.AreEqual(expect, actual, 0.5d);
        }

        [TestMethod()]
        public void DiscountTestCarNoDiscount()
        {
            //Arrange  
            Car car = new Car();
            //Act  
            car.Brobizz = true;
            car.Date = new DateTime(2021, 10, 4);
            var actual = Discount.GetDiscount(car);
            var expect = 228;
            //Assert
            Assert.AreEqual(expect, actual, 0.5d);
        }

        [TestMethod()]
        public void DiscountTestCarNoBrobizzt()
        {
            //Arrange  
            Car car = new Car();
            //Act  
            car.Date = new DateTime(2021, 10, 2);
            var actual = Discount.GetDiscount(car);
            var expect = 192;
            //Assert
            Assert.AreEqual(expect, actual, 0.5d);
        }
    }
}