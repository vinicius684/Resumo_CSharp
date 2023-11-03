using CSharp._7Enumeracoes_E_Composicao._05ExercicioProposto.Entities;
using CSharp._7Enumeracoes_E_Composicao._05ExercicioProposto.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp._7Enumeracoes_E_Composicao._05ExercicioProposto.Entities
{
    internal class Order
    {
        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; }
        public List<OrderItem> OrderItem { get; set; } = new List<OrderItem>();
        public Client Client { get; set; }

        public Order(OrderStatus status, Client client) { 
            Moment = DateTime.Now;
            Status = status;
            Client = client;
        }

        public void AddItem(OrderItem item) {
            OrderItem.Add(item);
        }

        public void RemoveItem(OrderItem item)
        {
            OrderItem.Remove(item);
        }

        public double TotalPrice() {
            double sum = 0;
            foreach (OrderItem itens in OrderItem)
            {
                sum = sum + itens.SubTotal();
            }
            return sum;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("ORDER SUMMARY:");
            sb.AppendLine("Order moment: " + Moment.ToString());
            sb.AppendLine("Order Status" + Status);
            sb.AppendLine("Client: " + Client.Name + "(" + Client.BirthDate + ")" + "-" + Client.Email);
            Console.WriteLine("Order Items");
            foreach (OrderItem obj in OrderItem)
            {
                sb.AppendLine(obj.Product.Name + ", $" + obj.Price + ", Quantity: " + obj.Quantity +", Subtotal: $" + obj.SubTotal());
            }
            sb.Append(TotalPrice());
            return sb.ToString();
        }
    }
}
