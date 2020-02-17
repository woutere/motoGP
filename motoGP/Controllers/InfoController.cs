using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using motoGP.Models;

namespace motoGP.Controllers
{
    public class InfoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ListRaces()
        {
            ViewData["BannerNr"] = (int)0;
            return View();
        }

        public IActionResult BuildMap()
        {
            ViewData["BannerNr"] = (int)0;
            List<Race> races = new List<Race>();
            races[0] = new Race(1, "Assen", 517, 19);
            races[1] = new Race(2, "Losail Circuit", 859, 249);
            races[2] = new Race(3, "Autódromo Termas de Río Hondo", 194, 428);
            ViewData["ListRaces"] = races;
            return View();

        }
        public IActionResult ListTeams()
        {
            ViewData["BannerNr"] = (int)2;
            return View();
        }

        public IActionResult ListRiders()
        {
            ViewData["BannerNr"] = (int)1;
            return View();
        }
    }
}