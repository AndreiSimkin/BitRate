using BitRate.Data.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BitRate.Controllers
{
    public class BitcoinController : Controller
    {
        private readonly IBitcoin _bitcoinRate;

        public BitcoinController(IBitcoin iBitconRate)
        {
            _bitcoinRate = iBitconRate;
        }

        public ViewResult Rate()
        {
            var rate = _bitcoinRate.getBitcoinRate();
            return View(rate);
        }
    }
}
