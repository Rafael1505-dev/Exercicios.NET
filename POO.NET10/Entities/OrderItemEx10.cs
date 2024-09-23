using System.Globalization;

namespace POO.NET10.Entities
{
    class OrderItemEx10
    {
        public int Quantity { get; set; }
        public double Price { get; set; }
        public ProductEx10 Product { get; set; }

        public OrderItemEx10(int quantity, double price, ProductEx10 product)
        {
            Quantity = quantity;
            Price = price;
            Product = product;
        }

        public double SubTotal ()
        {
            return Quantity * Price; 
        }

        public override string ToString()
        {
            return Product.Name
                + ", $"
                + Price.ToString("F2", CultureInfo.InvariantCulture)
                + " , Quantity: "
                + Quantity.ToString()
                + ", Subtotal: $"
                + SubTotal().ToString("F2", CultureInfo.InvariantCulture);    
        }
    }
}
