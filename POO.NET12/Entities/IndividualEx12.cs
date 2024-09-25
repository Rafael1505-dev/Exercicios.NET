using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO.NET12.Entities
{
    class IndividualEx12 : TaxPayerEx12
    {
        public double HealthExpenditures { get; set; }

        public IndividualEx12(string name, double anualIncome, double healthExpenditures): base (name, anualIncome)
        {
            HealthExpenditures = healthExpenditures;
        }

        public override double Tax()
        {
            if (AnualIncome < 20000)
            {
               return AnualIncome * 0.15 - (HealthExpenditures * 0.5);
            }
            else 
            {
                return AnualIncome * 0.25 - (HealthExpenditures * 0.5);
            }
        }
    }
}
