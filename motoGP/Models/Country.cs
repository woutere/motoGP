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
        public ICollection<Ticket> Tickets { get; set; }
        public ICollection<Rider> Riders { get; set; }

        public Country(int countryID, string name, ICollection<Ticket> tickets, ICollection<Rider> riders)
        {
            CountryID = countryID;
            Name = name;
            Tickets = tickets;
            Riders = riders;
        }

        public Country()
        {
        }
    }
}
