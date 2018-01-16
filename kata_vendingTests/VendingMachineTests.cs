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
    public class VendingMachineTests
    {
        [TestMethod()]
        public void acceptCoinTest()
        {
            VendingMachine machine = new VendingMachine();
            Assert.IsTrue(machine.acceptCoin(Money.Coin.nickel));
            Assert.IsTrue(machine.acceptCoin(Money.Coin.dime));
            Assert.IsTrue(machine.acceptCoin(Money.Coin.quarter));
            Assert.IsFalse(machine.acceptCoin(Money.Coin.invalid));
        }
    }
}