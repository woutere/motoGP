using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace motoGP.Models
{
    public class Team
    {
        public int TeamID { get; set; }
        public string Naam { get; set; }
        public string Logo { get; set; }

        public Team(int teamID, string naam, string logo)
        {
            TeamID = teamID;
            Naam = naam;
            Logo = logo;
        }

        public Team()
        {
        }
    }
}
