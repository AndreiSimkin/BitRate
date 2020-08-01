using BitRate.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BitRate.Data.Interfaces
{
    public interface IBitcoin
    {
        Rate getBitcoinRate();
    }
}
