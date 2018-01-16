using Microsoft.VisualStudio.TestTools.UnitTesting;
using kata_vending;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kata_vending.Tests
{
    [TestClass()]
    public class MoneyTests
    {
        [TestMethod()]
        public void getValueTest()
        {
            Assert.AreEqual(5m, Money.GetValue(Money.Coin.nickel));
            Assert.AreEqual(10m, Money.GetValue(Money.Coin.dime));
            Assert.AreEqual(25m, Money.GetValue(Money.Coin.quarter));
            Assert.AreEqual(0m, Money.GetValue(Money.Coin.invalid));
        }
    }
}