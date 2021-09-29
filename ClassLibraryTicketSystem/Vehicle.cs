using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryTicketSystem
{
    public abstract class Vehicle
    {
        private string licenseplate;

        public abstract double Price();
        public abstract string VehicleType();

        public string Licenseplate
        {
            get
            {
                return licenseplate;
            }
            set
            {
                if (value.Length > 7)
                    throw new ArgumentOutOfRangeException("License Plate should be less than 7 chars");
                else
                    licenseplate = value;
            }
        }
        public DateTime Date { get; set; }
    }
}
