using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kata_vending
{
    public class VendingMachine
    {
        private Money.Coin ?coin;

        public bool AcceptCoin(Money.Coin coin)
        {
            if (coin == Money.Coin.nickel || 
                coin == Money.Coin.dime ||
                coin == Money.Coin.quarter)
            {
                this.coin = coin;
                return true;
            }
            this.coin = null;
            return false;
        }

        public decimal AcceptedValue()
        {
            if (coin == null)
                return 0m;
            return Money.GetValue((Money.Coin) coin);
        }
    }
}
