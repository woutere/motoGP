using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace motoGP.Models
{
    public class Race
    {
        public Race(int raceID, string name, int x, int y)
        {
            RaceID = raceID;
            Name = name;
            X = x;
            Y = y;
        }

        public int RaceID { get; set; }
        public string Name { get; set; }
        public int countryID { get; set; }
        public Country country { get; set; }
        public string description { get; set; }
        public string length { get; set; }
        [DataType(DataType.Date)]
        public DateTime date { get; set; }
        public int X { get; set; }
        public int Y { get; set; }

    }
}
