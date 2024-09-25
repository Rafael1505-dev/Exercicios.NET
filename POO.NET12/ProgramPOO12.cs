using POO.NET12.Entities;
using System.Collections.Generic;
using System.Globalization;

namespace POO.NET12
{
    public class ProgramPOO12
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("\n===== Exercício de classe abstrata em C# =======\n\n");

            Console.Write("Enter the number of tax payers: ");
            int number = int.Parse(Console.ReadLine());

            List<TaxPayerEx12> taxPayer = new List<TaxPayerEx12>();
            double sum = 0.0;

            for (int i = 1; i <= number; i++)
            {
                Console.WriteLine($"Tax payer #{i} data:");
                Console.Write("Individual or company (i/c)? ");
                char type = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Anual income: ");
                double anualIncome = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if (type == 'i')
                {
                    Console.Write("Health expenditures: ");
                    double healthExpenditures = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    IndividualEx12 ind = new IndividualEx12(name, anualIncome, healthExpenditures);
                    taxPayer.Add(ind);
                }
                else
                {
                    Console.Write("Number of employees: ");
                    int employeeNumber = int.Parse(Console.ReadLine());

                    CompanyEx12 company = new CompanyEx12(name, anualIncome, employeeNumber);
                    taxPayer.Add(company);
                }
            }

            Console.WriteLine();
            Console.WriteLine("TAXES PAID: ");

            foreach (TaxPayerEx12 user in taxPayer)
            {
                Console.WriteLine(user);
                sum += user.Tax();
            }

            Console.WriteLine();
            Console.Write("TOTAL TAXES: $ " + sum.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
