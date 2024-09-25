using POO.NET13.Entities;
using POO.NET13.Entities.Exceptions;
using System.Collections.Generic;
using System.Globalization;

namespace POO.NET13
{
    public class ProgramPOO13
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("\n===== Exercício de Exception em C# =======\n\n");

            try
            {
                Console.WriteLine("Enter account data");
                Console.Write("Number: ");
                int number = int.Parse(Console.ReadLine());
                Console.Write("Holder: ");
                string holder = Console.ReadLine();
                Console.Write("Initial balance: ");
                double balance = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Withdraw limit: ");
                double limit = double.Parse(Console.ReadLine() , CultureInfo.InvariantCulture);

                AccountEx13 account = new AccountEx13(number, holder, balance, limit);

                Console.WriteLine();

                Console.Write("Enter amount for withdraw: ");
                double amount = double.Parse(Console.ReadLine() ,CultureInfo.InvariantCulture);
                account.Withdraw(amount);

                Console.WriteLine("New balance: " + account.Balance.ToString("F2", CultureInfo.InvariantCulture));

            }
            catch(DomainException e) 
            {
                Console.WriteLine("Withdraw error: " + e.Message);
            }
        }
    }
}