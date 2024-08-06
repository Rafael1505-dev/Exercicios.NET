using System;
using System.Globalization;


namespace POO.NET02
{
    public class ProgramPOO2
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("\n===== Exercício que calcula a média salrial entre dois funcionários em C# =======\n\n");

            CultureInfo culture = CultureInfo.InvariantCulture;

            EmployeeEx2 emp1, emp2;
            double averageSalary;
            emp1 = new EmployeeEx2();
            emp2 = new EmployeeEx2();

            Console.WriteLine("Dados do primeiro funcionário: ");
            Console.Write("Nome: ");
            emp1.name = Console.ReadLine();
            Console.Write("Salário: ");
            emp1.salary = double.Parse(Console.ReadLine(), culture);

            Console.WriteLine("Dados do segundo funcionário: ");
            Console.Write("Nome: ");
            emp2.name = Console.ReadLine();
            Console.Write("Salário: ");
            emp2.salary = double.Parse(Console.ReadLine(), culture);

            averageSalary = EmployeeEx2.SalaryAverage(emp1 , emp2 );

            Console.WriteLine($"Salário Médio = {averageSalary.ToString("F2", culture)}");
        }
    }
}