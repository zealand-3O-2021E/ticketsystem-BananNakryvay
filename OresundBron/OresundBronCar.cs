using ClassLibraryTicketSystem;
using System;

namespace OresundBron
{
    public class OresundBronCar : Vehicle
    {
        
        /// <summary>
        /// Return the price of cars
        /// </summary>
        /// <returns> 410 </returns>
        public override double Price()
        {
            //if Brobizz - 161
            if (Brobizz)
                return 161;
            return 410;
        }
        /// <summary>
        ///  Return the vehicle type of cars
        /// </summary>
        /// <returns> return Car </returns>
        public override string VehicleType()
        {
            return "Oresund Car";
        }

    }
}
