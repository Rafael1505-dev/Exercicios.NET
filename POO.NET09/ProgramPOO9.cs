using POO.NET08;
using System;
using System.Globalization;
using System.Collections.Generic;
using POO.NET09;

namespace POO.NET08
{
    public class ProgramPOO8
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("\n===== Exercício Aumento Salarial com Lista em C# =======\n\n");

            Console.Write("How many employees will be registered? ");
            int number = int.Parse(Console.ReadLine());

            List<EmployeeEx9> listEmployee = new List<EmployeeEx9>();

            for (int i = 1; i <= number; i++)
            {
                Console.WriteLine();

                Console.WriteLine($"Emplyoee #{i}:");
                Console.Write("Id: ");
                int id = int.Parse(Console.ReadLine());

                Console.Write("Name: ");
                string name = Console.ReadLine();

                Console.Write("Salary: ");
                double salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                listEmployee.Add(new EmployeeEx9(id, name, salary));
            }

            Console.WriteLine();
            Console.Write("Enter the employee id that will have salary increase : ");
            int idEmployee = int.Parse(Console.ReadLine());

            EmployeeEx9 employee = listEmployee.Find(x => x.Id == idEmployee);

            if (employee != null) 
            {
                Console.Write("Enter the percentage: ");
                double percentage = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                employee.IncreaseSalary(percentage);
            }
            else
            {
                Console.WriteLine("This id does not exist!");
            }

            Console.WriteLine();
            Console.WriteLine("Updated list of employees: ");

            foreach (EmployeeEx9 obj in listEmployee)
            {
                Console.WriteLine(obj);
            }
        }
    }

}