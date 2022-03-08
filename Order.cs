using System;
using System.Collections.Generic;
using System.Text;

namespace Primeiro.Entities
{
    class Order
    {
        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; }
        public Client Client { get; set; }
        public List<OrderItem> Itens { get; set; } = new List<OrderItem>();

        public Order(DateTime momento, OrderStatus status, Client cliente)
        {
            Moment = momento;
            Status = status;
            Client = cliente;
        }

        public void AddItem(OrderItem itens) 
        {
            Itens.Add(itens);
        }

        public void RemoveItem(OrderItem itens) 
        { 
            Itens.Remove(itens);
        }

        public double Total()
        {
            double sum = 0.0;
            foreach (OrderItem item in Itens)
            {
                sum += item.Subtotal();
            }
            return sum;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("ORDER SUMMARY: ");
            sb.Append("Order moment: ");
            sb.AppendLine(Moment.ToString("dd/MM/yyyy HH:mm:ss"));
            sb.Append("Order status: ");
            sb.AppendLine(Status.ToString());
            sb.AppendLine("Client: " + Client);
            sb.AppendLine("Order items: ");

            foreach (OrderItem item in Itens)
            {
                sb.AppendLine(item.ToString());
            }
            sb.AppendLine("Total price: $" + Total().ToString());
            return sb.ToString();
        }
    }
}
