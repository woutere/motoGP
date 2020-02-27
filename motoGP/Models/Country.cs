using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace motoGP.Models
{
    public class Country
    {
        public int CountryID { get; set; }
        public string Name { get; set; }
        public ICollection<Ticket> tickets { get; set; }
        public ICollection<Rider> riders { get; set; }
    }
}
