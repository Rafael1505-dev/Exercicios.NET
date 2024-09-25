using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace POO.NET12.Entities
{
    abstract class TaxPayerEx12
    {
        public string Name { get; set; }
        public double AnualIncome { get; set; }

        protected TaxPayerEx12(string name, double anualIncome)
        {
            Name = name;
            AnualIncome = anualIncome;
        }

        public abstract double Tax();

        public override string ToString()
        {
            return Name + ": $ " + Tax().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
