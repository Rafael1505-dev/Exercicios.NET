using System.Globalization;
using POO.NET10.Entities;
using POO.NET10.Entities.Enums;


namespace POO.NET10
{
    public class ProgramPOO10
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("\n===== Exercício de Pedidos em C# =======\n\n");

            Console.WriteLine("Enter cliente data: ");
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Email: ");
            string email = Console.ReadLine();
            Console.Write("Birth date (DD/MM/YYYY): ");
            DateTime birthdate = DateTime.Parse(Console.ReadLine());

            Console.WriteLine("Enter cliente data: ");
            Console.Write("Status:");
            OrderStatusEx10 status = Enum.Parse<OrderStatusEx10>(Console.ReadLine());

            ClientEx10 customer = new ClientEx10(name, email, birthdate);
            OrderEx10 order = new OrderEx10(DateTime.Now, status, customer);

            Console.Write("How many items to this order? ");
            int itemOrder = int.Parse(Console.ReadLine());

            for (int i = 1; i <= itemOrder; i++)
            {
                Console.WriteLine($"Enter #{i} item data:");
                Console.Write("Product Name: ");
                string pName = Console.ReadLine();
                Console.Write("Product Price: ");
                double pPrice = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Quantity: ");
                int pqtty = int.Parse(Console.ReadLine());

                ProductEx10 product = new ProductEx10(pName,pPrice);

                OrderItemEx10 orderItem = new OrderItemEx10(pqtty,pPrice,product);

                order.AddItem(orderItem);
            }
            Console.WriteLine();

            Console.WriteLine("ORDER SUMMARY: ");
            Console.WriteLine(order);
        }
    }
}