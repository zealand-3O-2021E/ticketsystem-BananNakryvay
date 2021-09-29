using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryTicketSystem
{
    public abstract class Vehicle
    {
        public abstract double Price();
        public abstract string VehicleType();

        public string Licenseplate { get; set; }
        public DateTime Date { get; set; }
    }
}
