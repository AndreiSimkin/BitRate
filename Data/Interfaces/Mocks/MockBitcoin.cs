﻿using BitRate.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BitRate.Data.Interfaces.Mocks
{
    public class MockBitcoin : IBitcoin
    {

        public Rate getBitcoinRate()
        {
            Rate rate =  Services.Bitmex.GetRate();
            return rate; 
        }
    }
}
