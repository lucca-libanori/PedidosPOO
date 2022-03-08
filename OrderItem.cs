using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Primeiro.Entities
{
    class OrderItem
    {
        public int Quantity { get; set; }
        public double Price { get; set; }
        public Product Product { get; set; }

        public OrderItem()
        {

        }

        public OrderItem(int quantidade, double preco, Product produto)
        {
            Quantity = quantidade;
            Price = preco;
            Product = produto;
        }

        public double Subtotal()
        {
            return Quantity * Price;
        }

        public override string ToString()
        {
            return Product.Name
                + ", $"
                + Price.ToString()
                + ", Quantity: "
                + Quantity
                + ", Subtotal: $"
                + Subtotal().ToString();
        }
    }
}
