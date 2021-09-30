using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryTicketSystem
{
    public class MC:Vehicle
    {


        /// <summary>
        /// Return the price of motorcycle
        /// </summary>
        /// <returns> 125 </returns>
        public override double Price()
        {
            if (Brobizz)
                return 125 * 0.95;
            return 125;
        }
        /// <summary>
        ///  Return the vehicle type of motorcycles
        /// </summary>
        /// <returns> return MC </returns>
        public override string VehicleType()
        {
            return "MC";
        }

    }
}
