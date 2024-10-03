using System;
using System.Collections.Generic;
using System.IO;
using System.Globalization;
using POO.NET17.Entities;
using System.Linq;

namespace POO.NET17
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n===== Exercício com Linq em C# =======\n\n");

            List<Employee> employees = new List<Employee>();

            Console.Write("Enter file full path: ");
            string path = Console.ReadLine().Trim();

            try
            {
                using (StreamReader sr = File.OpenText(path))
                {
                    while (!sr.EndOfStream)
                    {
                        string[] line = sr.ReadLine().Split(',');
                        string name = line[0];
                        string email = line[1];
                        double salary = double.Parse(line[2], CultureInfo.InvariantCulture);

                        Employee emp = new Employee(name, email, salary);

                        employees.Add(emp);
                    }
                }

                Console.Write("Enter salary: ");
                double salarySearch = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Console.WriteLine($"Email of people whose salary is more than {salarySearch:F2}:");

                var emailsSearch = employees.Where(p => p.Salary > salarySearch).OrderBy(p => p.Email).Select(p => p.Email);

                foreach (string emp in emailsSearch) {
                    Console.WriteLine(emp);
                }

                var sum = employees.Where(p => p.Name[0] == 'M').Select(p => p.Salary).Sum();


                Console.WriteLine("Sum of salary of people whose name starts with 'M': " + sum.ToString("F2", CultureInfo.InvariantCulture));

            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}