using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace motoGP.Controllers
{
    public class ShopController : Controller
    {
        public IActionResult Orderticket()
        {
            ViewData["BannerNr"] = (int)3;
            return View();
        }
        public IActionResult ConfirmOrder()
        {
            ViewData["BannerNr"] = (int)3;
            return View();
        }
    }
}