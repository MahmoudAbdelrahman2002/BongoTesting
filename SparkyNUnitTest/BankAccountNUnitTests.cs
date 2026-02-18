using Moq;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sparky
{
    [TestFixture]
    public class BankAccountNUnitTests
    {
        private BankAccount _bankAccount;
        [SetUp]
        public void Setup()
        {


        }



        [Test]
        public void AddDeposit_Add100_ReturnsTrue()
        {
            var logMoq = new Moq.Mock<ILogBook>();
            BankAccount _bankAccount = new BankAccount(logMoq.Object);
            var result = _bankAccount.Deposit(100);
            Assert.That(result, Is.True);

        }

        [Test]
        public void Withdraw_Withdraw100WithBalance200_ReturnsTrue()
        {
            var logMoq = new Moq.Mock<ILogBook>();
            logMoq.Setup(x => x.LogBalanceAfterWithdrawal(It.IsAny<int>())).Returns(true);
            logMoq.Setup(x => x.LogToDb(It.IsAny<string>())).Returns(true);

            BankAccount _bankAccount = new BankAccount(logMoq.Object);
            _bankAccount.Deposit(200);
            var result = _bankAccount.Withdraw(100);
            Assert.That(result, Is.True);

        }
        [Test]
        public void Withdraw_Withdraw300WithBalance200_ReturnsFalse()
        {
            var logMoq = new Moq.Mock<ILogBook>();
            logMoq.Setup(x => x.LogBalanceAfterWithdrawal(It.IsAny<int>())).Returns(false);




            BankAccount _bankAccount = new BankAccount(logMoq.Object);
            _bankAccount.Deposit(200);
            var result = _bankAccount.Withdraw(300);
            Assert.That(result, Is.False);

        }
    }
}
