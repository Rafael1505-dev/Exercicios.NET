using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace POO.NET07
{
    internal class BankAccountEx7
    {
        public string NameHolder{ get; private set; }
        public double Balance { get; private set; }
        public int AccountNumber { get; set; }       
        
        internal BankAccountEx7(string nameHolder, int accountNumber)
        {
            NameHolder = nameHolder;
            AccountNumber = accountNumber;
        }

        internal BankAccountEx7(string nameHolder, int accountNumber, double balance) : this(nameHolder,accountNumber)
        {
            NameHolder = nameHolder;
            AccountNumber = accountNumber;
            Balance = balance;
        }

        public void Deposit (double amount)
        {
            Balance += amount;
        }

        public void Withdraw(double amount)
        {
            Balance -= (amount + 5);
        }

        public override string ToString()
        {
            return "Conta " + AccountNumber + ", Titular: " + NameHolder 
                + ", Saldo: $ " + Balance.ToString("F2", CultureInfo.InvariantCulture);

        }
    }
}
