using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace motoGP.Models
{
    public class Ticket
    {
        public int TicketID { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Addresss { get; set; }
        public int CountryID { get; set; }
        public Country Country { get; set; }
        public int RaceID { get; set; }
        public Race Race { get; set; }
        public int Number { get; set; }
        [DataType(DataType.Date)]
        public DateTime OrderDate { get; set; }
        public string Paid { get; set; }

        public Ticket(int ticketID, string name, string email, string addresss, int countryID, Country country, int raceID, Race race, int number, DateTime orderDate, string paid)
        {
            TicketID = ticketID;
            Name = name;
            Email = email;
            Addresss = addresss;
            CountryID = countryID;
            Country = country;
            RaceID = raceID;
            Race = race;
            Number = number;
            OrderDate = orderDate;
            Paid = paid;
        }

        public Ticket()
        {
        }
    }
}
