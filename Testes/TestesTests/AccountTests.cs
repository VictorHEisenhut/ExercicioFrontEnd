using Microsoft.VisualStudio.TestTools.UnitTesting;
using Testes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testes.Tests
{
    [TestClass()]
    public class AccountTests
    {
        [TestMethod()]
        public void WithdrawTest()
        {
            //arrange
            Account account = new Account();
            account.Balance = 100.0;
            double valorEsperado = 10.0;

            //act
            account.Withdraw(90.0);

            //assert
            Assert.AreEqual(valorEsperado, account.Balance);
        }

        [TestMethod()]
        public void WithdrawTestThrowException() 
        {
            Account account = new Account();

            Assert.ThrowsException<ArgumentException>(() => account.Withdraw(20));
        }

        [TestMethod()]
        public void StoreTestThrowException()
        {
            Account account = new Account();

            Assert.ThrowsException<ArgumentException>(() => account.Store(-20));
        }
    }
}