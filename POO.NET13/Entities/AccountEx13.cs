using POO.NET13.Entities.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO.NET13.Entities
{
    class AccountEx13
    {
        public int Number { get; set; }
        public string Holder { get; set; }
        public double Balance { get; set; }
        public double WithdrawLimit { get; set; }

        public AccountEx13(int number, string holder, double balance, double withdrawLimit)
        {
            Number = number;
            Holder = holder;
            Balance = balance;
            WithdrawLimit = withdrawLimit;
        }

        public void Deposit (double amount)
        {
            Balance += amount;
        }

        public void Withdraw (double amount)
        {
            if (WithdrawLimit < amount)
            {
                throw new DomainException("The amount exceeds withdraw limit");
            }
            else if (Balance < amount)
            {
                throw new DomainException("Not enough balance");
            }
            else
            {
                Balance -= amount;
            }
           
        }
    }
}
