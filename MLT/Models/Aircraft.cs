using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MLT.Models
{
    public class Aircraft
    {
        public int Id { get; set; }
        //
        [StringLength(100)] // Adding a string length of 100 to AircraftType
        public string AircraftType { get; set; }
        //
        [StringLength(6)] // Adding a string length of 6 to AircraftIdent
        public string AircraftIdent { get; set; }
        //
        [StringLength(24)] // String length to 24 as max option required is 24 characters
        public string AircraftState { get; set; }

        public Aircraft()
        {

        }

    }
}
