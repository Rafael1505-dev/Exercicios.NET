using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO.NET02
{
    public class EmployeeEx2
    {
        public string name;
        public double salary;

        public static double SalaryAverage (EmployeeEx2 obj1, EmployeeEx2 obj2)
        {
            double avg = (obj1.salary + obj2.salary)/2;

            return avg;
        }
    }
}
