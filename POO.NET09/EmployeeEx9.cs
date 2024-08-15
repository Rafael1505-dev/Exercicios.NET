using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO.NET09
{
    internal class EmployeeEx9
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Salary { get; private set; }

        public EmployeeEx9(int id, string name, double salary)
        {
            Id = id;
            Name = name;
            Salary = salary;
        }

        public void IncreaseSalary(double percentage)
        {
            Salary += (Salary * percentage)/100.00;
        }

        public override string ToString()
        {
            return Id + ", " + Name + ", " + Salary.ToString("F2");
        }
    }
}
