using System;
using System.Collections.Generic;
using System.Text;

namespace Bank
{
    public class BankAccount
    {
        public int Id { get; set; }
        public decimal Money { get; set; }

        public void Deposit(decimal moneyAmout)
        {
            if(moneyAmout <= 0)
            {
                throw new ArgumentException();
            }
            this.Money += moneyAmout;
        }
    }
}
