using System;

namespace Bank
{
    public class StartUp
    {
        public static void Main()
        {
            BankAccount bankAccount = new BankAccount();
            bankAccount.Id = 5;
            bankAccount.Deposit(20);
            Console.WriteLine(bankAccount.Money);
        }
    }
}
