using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace POO.NET11.Entities
{
    class ProductEx11
    {
        public string Name { get; set; }
        public double Price { get; set; }

        public ProductEx11(string name, double price)
        {
            Name = name;
            Price = price;
        }

        public virtual string PriceTag ()
        {
            return Name + " $ " + Price.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
