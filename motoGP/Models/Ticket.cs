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
        public int countryID { get; set; }
        public Country country { get; set; }
        public int raceID { get; set; }
        public Race race { get; set; }
        public int Number { get; set; }
        [DataType(DataType.Date)]
        public DateTime orderDate { get; set; }
        public bool paid { get; set; }
    }
}
