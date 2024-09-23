using POO.NET10.Entities.Enums;
using System.Text;
using System.Globalization;


namespace POO.NET10.Entities
{
    class OrderEx10
    {
        public DateTime Moment { get; set; }
        public OrderStatusEx10 Status { get; set; }
        public ClientEx10 Client { get; set; }

        public List<OrderItemEx10> Items { get; set;} = new List<OrderItemEx10>();

        public OrderEx10(DateTime moment, OrderStatusEx10 status, ClientEx10 client)
        {
            Moment = moment;
            Status = status;
            Client = client;
        }

        public void AddItem(OrderItemEx10 item)
        {
            Items.Add(item);
        }

        public void RemoveItem(OrderItemEx10 item) 
        { 
            Items.Remove(item); 
        }

        public double Total()
        {
            double sum = 0.0;
            foreach (OrderItemEx10 item in Items)
            {
                sum += item.SubTotal();
            }
            return sum;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("Order moment " + Moment.ToString("dd/MM/yyyy HH:mm:ss"));
            sb.AppendLine("Order status: " + Status);
            sb.AppendLine("Client: " + Client);
            sb.AppendLine("Order items:");
            
            foreach (OrderItemEx10 item in Items)
            {
                sb.AppendLine(item.ToString());
            }

            sb.AppendLine("Total price: $" + Total().ToString("F2", CultureInfo.InvariantCulture));


            return sb.ToString();
        }

    }
}
