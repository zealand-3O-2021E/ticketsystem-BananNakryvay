using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryTicketSystem
{
    public class Car
    {

        public string Licenseplate { get; set; }
        public DateTime Date { get; set; }

        /// <summary>
        /// Return the price of cars
        /// </summary>
        /// <returns> 240 </returns>
        public double Price()
        {
            return 240;
        }
        /// <summary>
        ///  Return the vehicle type of cars
        /// </summary>
        /// <returns> return Car </returns>
        public string VehicleType()
        {
            return "Car";
        }


    }
}
