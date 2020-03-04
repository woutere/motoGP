using System;
using System.ComponentModel.DataAnnotations;

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
        public string Description { get; set; }
        public string Length { get; set; }
        [DataType(DataType.Date)]
        public DateTime Date { get; set; }
        public int X { get; set; }
        public int Y { get; set; }

        public Race(int raceID, string name,string description, string length, DateTime date, int x, int y)
        {
            RaceID = raceID;
            Name = name;
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
