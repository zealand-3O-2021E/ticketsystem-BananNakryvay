using ClassLibraryTicketSystem;
using System;

namespace StoreBaeltTicketLibrary
{
    public class Discount
    {
        public static double GetDiscount(Car car)
        {
            var day = car.Date.ToString("dddd");
            if (day == "Saturday" || day == "Sunday")
                return car.Price() * .80;
            return car.Price();
        }
    }
}
