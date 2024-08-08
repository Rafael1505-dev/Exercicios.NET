using POO.NET04;
using POO.NET4;
using System;
using System.ComponentModel;
using System.Globalization;


namespace POO.NET04
{
    public class ProgramPOO4
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("\n===== Exercício que calcula operações salariais em C# =======\n\n");

            CultureInfo culture = CultureInfo.InvariantCulture;

            EmployeeEx4 employee = new EmployeeEx4();
            double percents;

            Console.Write("Nome: ");
            employee.Name = Console.ReadLine();

            Console.Write("Salário Bruto: ");
            employee.GrossSalary = double.Parse(Console.ReadLine(), culture);

            Console.Write("Imposto: ");
            employee.Tax = double.Parse(Console.ReadLine(), culture);

            Console.WriteLine();
            Console.WriteLine("Funcionário: " + employee);

            Console.WriteLine();
            Console.Write("Digite a porcentagem para aumentar o salário: ");

            percents = double.Parse(Console.ReadLine(), culture);

            employee.ToGiveARaise(percents);

            Console.WriteLine();
            Console.WriteLine("Funcionário: " + employee);
        }
    }
}