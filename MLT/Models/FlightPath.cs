using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MLT.Models
{
    public class FlightPath
    {
        public int Id { get; set; }
        //
        [StringLength(6)] // Adding a string length of 6 to FlightID MLT###
        public string FlightID { get; set; }
        //
        [StringLength(56)] // Adding a string length of 56 to Origin
        public string Origin { get; set; }
        //
        [StringLength(56)] // Adding a string length of 56 to Destination
        public string Destination { get; set; }

        public FlightPath()
        {

        }
    }
}
