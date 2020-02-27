using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace motoGP.Models
{
    public class Rider
    {
        public int riderId { get; set; }
        public string lastnNme { get; set; }
        public string firstName { get; set; }
        public int countryID { get; set; }
        public Country country { get; set; }
        public int teamID { get; set; }
        public Team team { get; set; }
        public string Bike { get; set; }
        public int Number { get; set; }
    }
}
