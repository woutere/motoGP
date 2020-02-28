using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace motoGP.Models
{
    public class Rider
    {
        public int RiderId { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public int CountryID { get; set; }
        public Country Country { get; set; }
        public int TeamID { get; set; }
        public Team Team { get; set; }
        public string Bike { get; set; }
        public int Number { get; set; }

        public Rider(int riderId, string lastName, string firstName, int countryID, Country country, int teamID, Team team, string bike, int number)
        {
            RiderId = riderId;
            LastName = lastName;
            FirstName = firstName;
            CountryID = countryID;
            Country = country;
            TeamID = teamID;
            Team = team;
            Bike = bike;
            Number = number;
        }

        public Rider()
        {
        }
    }
}
