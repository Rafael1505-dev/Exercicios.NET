using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO.NET4
{
    public class EmployeeEx4
    {
        public string Name;
        public double GrossSalary;
        public double Tax;

        public double NetSalary()
        {
            double salary = GrossSalary - Tax;
            return salary;
        }

        public void ToGiveARaise(double percent)
        {
            GrossSalary += ((GrossSalary * percent)/100);
        }

        public override string ToString()
        {
            return Name
            + ", R$ "
            + NetSalary().ToString("F2", CultureInfo.InvariantCulture);
        }

    }
}
