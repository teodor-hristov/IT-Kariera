using System;
using NUnit.Framework;
namespace Bank.Tests
{
    [TestFixture]
    class BankTests
    {
        private BankAccount bankAccount;

        [SetUp]
        public void SetUp()
        {
            this.bankAccount = new BankAccount();   
        }

        [TestCase(100)]
        [TestCase(50)]
        [TestCase(1.80)]
        public void DepositShouldIncreaseBalance(decimal depositAmount)
        {
            //Act
            bankAccount.Deposit(depositAmount);

            //Assert
            Assert.AreEqual(depositAmount,bankAccount.Money);
        }
        [Test]
        public void NegativeAmountInDepositShouldThrowException()
        {
            //Arrange
            decimal depositAmount = -100;

            //Assert
            Assert.Throws<ArgumentException>(
                () =>
                {
                    bankAccount.Deposit(depositAmount);
                }
                );
        }

    }
}
