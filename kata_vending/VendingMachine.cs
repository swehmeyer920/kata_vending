using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kata_vending
{
    public class VendingMachine
    {
        public bool acceptCoin(Money.Coin coin)
        {
            if (coin == Money.Coin.nickel)
                return true;
            if (coin == Money.Coin.dime)
                return true;
            if (coin == Money.Coin.quarter)
                return true;
            return false;
        }
    }
}
