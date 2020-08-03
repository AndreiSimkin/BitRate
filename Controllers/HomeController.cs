using BitRate.Data.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BitRate.Data.Models;

namespace BitRate.Controllers
{
    public class HomeController : Controller
    {
        private readonly IBitcoin _bitcoinRate;

        public HomeController(IBitcoin iBitconRate)
        {
            _bitcoinRate = iBitconRate;
        }

        public ViewResult Index(Rate rate)
        {
            return View(rate);
        }

        public IActionResult Update()
        {
            return RedirectToAction("Index", Services.Bitmex.GetCurrentRate());
        }
    }
}