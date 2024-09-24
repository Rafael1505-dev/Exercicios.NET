using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace POO.NET11.Entities
{
    class ImportedProductEx11 : ProductEx11
    {
        public double CustomsFee { get; set; }

        public ImportedProductEx11(string name, double price, double customsFree) : base (name, price)
        {
            CustomsFee = customsFree;
        }

        public override string PriceTag()
        {
            return base.Name + " $ " + TotalPrice().ToString("F2", CultureInfo.InvariantCulture) 
                + " (Customs Fee: $ " + CustomsFee.ToString("F2", CultureInfo.InvariantCulture) + ")";
        }

        public double TotalPrice()
        {
            return base.Price + CustomsFee;
        }
    }
}
