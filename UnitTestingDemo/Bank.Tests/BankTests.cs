using System;
using NUnit.Framework;
namespace Bank.Tests
{
    [TestFixture]
    class BankTests
    {
       [Test]
       public void DepositShouldIncreaseBalance()
        {
            //Arrange
            BankAccount bankAccount = new BankAccount();
            decimal depositAmount = 100;

            //Act
            bankAccount.Deposit(depositAmount);

            //Assert
            Assert.AreEqual(depositAmount,bankAccount.Money);
        }
    }
}
