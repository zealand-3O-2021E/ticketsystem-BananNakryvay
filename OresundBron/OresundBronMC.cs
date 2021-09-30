using ClassLibraryTicketSystem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OresundBron
{
    public class OresundBronMC : Vehicle
    {
        /// <summary>
        /// Return the price of motorcycle
        /// </summary>
        /// <returns> 125 </returns>
        public override double Price()
        {
            //with discount 73
            if (Brobizz)
                return 73;
            return 210;
        }
        /// <summary>
        ///  Return the vehicle type of motorcycles
        /// </summary>
        /// <returns> return MC </returns>
        public override string VehicleType()
        {
            return "Oresund MC";
        }
    }
}
