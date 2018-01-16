using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kata_vending
{
    public class Money
    {
        public enum Coin
        {
            invalid = 0,
            nickel = 1,
            dime = 2,
            quarter = 3
        }

        public static decimal GetValue(Coin coin)
        {
            switch (coin)
            {
                case Coin.invalid:
                    break;
                case Coin.nickel:
                    return 5M;
                case Coin.dime:
                    return 10M;
                case Coin.quarter:
                    return 25M;
            }
            return 0M;
        }
    }
}
