using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MLT.Models
{
    public class Flight
    {
        public int Id { get; set; }
        public string FlightID { get; set; }
        public string Origin { get; set; }
        public string Destination { get; set; }

        public Flight()
        {

        }
    }
}
