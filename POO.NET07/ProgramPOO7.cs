using POO.NET07;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Globalization;
using System.Runtime.ConstrainedExecution;
using System.Security.Principal;


namespace POO.NET07
{
    public class ProgramPOO7
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("\n===== Exercício operacional de um banco em C# =======\n\n");

            BankAccountEx7 account;
            double deposit, withdraw;

            Console.Write("Entre o número da conta: ");
            int accountNumber = int.Parse(Console.ReadLine());

            Console.Write("Entre o titular da conta: ");
            string nameHolder = Console.ReadLine();

            Console.Write("Haverá depósito inicial (s/n)? ");
            char option = char.Parse(Console.ReadLine());

            if (option == 's')
            {
                Console.Write("Entre o valor de depósito inicial: ");
                deposit = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                account = new BankAccountEx7(nameHolder, accountNumber,deposit);
            }
            else
            {
                account = new BankAccountEx7(nameHolder,accountNumber);
            }

            Console.WriteLine();

            Console.WriteLine("Dados da conta:");
            Console.WriteLine(account);

            Console.WriteLine();

            Console.Write("Entre um valor para depósito: ");
            deposit = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            account.Deposit(deposit);
            Console.WriteLine("Dados da conta atualizados: ");
            Console.WriteLine(account);

            Console.WriteLine();

            Console.Write("Entre um valor para saque: ");
            withdraw = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            account.Withdraw(withdraw);
            Console.WriteLine("Dados da conta atualizados: ");
            Console.WriteLine(account);
        }
    }
}
