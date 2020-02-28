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
        public int CountryID { get; set; }
        public Country Country { get; set; }
        public string Description { get; set; }
        public string Length { get; set; }
        [DataType(DataType.Date)]
        public DateTime Date { get; set; }
        public int X { get; set; }
        public int Y { get; set; }

        public Race(int raceID, string name, int countryID, Country country, string description, string length, DateTime date, int x, int y)
        {
            RaceID = raceID;
            Name = name;
            CountryID = countryID;
            Country = country;
            Description = description;
            Length = length;
            Date = date;
            X = x;
            Y = y;
        }

        public Race()
        {
        }
    }
}
