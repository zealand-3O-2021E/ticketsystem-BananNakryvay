using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryTicketSystem
{
    public class MC
    {


        public string Licenseplate { get; set; }
        public DateTime Date { get; set; }

        /// <summary>
        /// Return the price of motorcycle
        /// </summary>
        /// <returns> 125 </returns>
        public double Price()
        {
            return 125;
        }
        /// <summary>
        ///  Return the vehicle type of motorcycles
        /// </summary>
        /// <returns> return MC </returns>
        public string VehicleType()
        {
            return "MC";
        }

    }
}
