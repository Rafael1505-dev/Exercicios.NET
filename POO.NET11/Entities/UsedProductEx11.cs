using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO.NET11.Entities
{
    class UsedProductEx11 : ProductEx11
    {
        public DateTime ManufactureDate { get; set; }

        public UsedProductEx11(string name, double price, DateTime manufactureDate) : base (name, price)
        {
            ManufactureDate = manufactureDate;
        }

        public override string PriceTag()
        {
            return base.Name + " (used) $ " + base.Price.ToString("F2", CultureInfo.InvariantCulture) + 
                " (Manufacture Date: " + ManufactureDate.ToString("dd/MM/yyyy") + ")";
        }

    }
}
