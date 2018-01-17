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
            Assert.IsTrue(machine.AcceptCoin(Money.Coin.nickel));
            Assert.IsTrue(machine.AcceptCoin(Money.Coin.dime));
            Assert.IsTrue(machine.AcceptCoin(Money.Coin.quarter));
            Assert.IsFalse(machine.AcceptCoin(Money.Coin.invalid));
        }
        [TestMethod()]
        public void storeCoinTest()
        {
            VendingMachine machine = new VendingMachine();
            machine.AcceptCoin(Money.Coin.nickel);
            Assert.AreEqual(5m, machine.AcceptedValue());
            machine.AcceptCoin(Money.Coin.dime);
            Assert.AreEqual(10m, machine.AcceptedValue());
            machine.AcceptCoin(Money.Coin.quarter);
            Assert.AreEqual(25m, machine.AcceptedValue());
            machine.AcceptCoin(Money.Coin.invalid);
            Assert.AreEqual(0m, machine.AcceptedValue());
        }
    }
}