using System;
using Primeiro.Entities;
using System.Globalization;

namespace Primeiro
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter client data:");
            Console.Write("Name: ");
            string n = Console.ReadLine();
            Console.Write("Email: ");
            string e = Console.ReadLine();
            Console.Write("Birth Date (MM/DD/YYYY): ");
            DateTime db = DateTime.Parse(Console.ReadLine());         
            Console.WriteLine("Enter order data: ");
            Console.Write("Status: ");
            OrderStatus status = Enum.Parse<OrderStatus>(Console.ReadLine());
            
            Client clientes = new Client(n, e, db);
            Order pedido = new Order(DateTime.Now, status, clientes);

            Console.Write("How many items to this order: ");
            int x = int.Parse(Console.ReadLine());

            for(int i = 1; i <= x; i++)
            {
                Console.WriteLine($"Enter #{i} item data:");
                Console.Write("Product name: ");
                string produto = Console.ReadLine();
                Console.Write("Product price: ");
                double preco = double.Parse(Console.ReadLine());
                Console.Write("Quantity: ");
                int quantidade = int.Parse(Console.ReadLine());
                Product p = new Product(produto, preco);
                OrderItem itens = new OrderItem(quantidade, preco, p);
                pedido.AddItem(itens);
            }
            Console.WriteLine(pedido);
        }
    }
}