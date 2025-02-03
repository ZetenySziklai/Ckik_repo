using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using NUnit.Framework.Internal;
using NUnit.Framework.Legacy;
namespace _2025_01_24_Teszt
{
    [TestFixture]
   
    internal class Teszt_BankAccount
    {
        BankAccount customer;
        [SetUp]
        public void SetUp()
        {
            customer = new BankAccount(2000);
        }
        [Test]
        public void BankAccount_BalanceValue()
        {
            ClassicAssert.AreEqual(customer.Balance, 2000);
        }

        [Test]
        public void BankAccount_Deposit_IncreaseBalance()
        {
            customer.Deposit(50);
            ClassicAssert.AreEqual(customer.Balance, 2050);
        }

        [Test]
        public void BankAccount_Interest_GiveBack25()
        {
            double interest = customer.Interest(25);
            ClassicAssert.AreEqual(interest, 500);
        }
        [Test]
        public void BankAccount_IncreaseInterest20()
        {
            double increase = customer.Increase(20);
            ClassicAssert.AreEqual(increase, 2400);
        }

        [Test]
        public void BankAccount_DecreaseInterest20()
        {
            double dicrease = customer.Decrease(20);
            ClassicAssert.AreEqual(dicrease, 1600);
        }
    }
}
