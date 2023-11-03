using CSharp._7Enumeracoes_E_Composicao._03Composicao.Entities.Enums;
using CSharp._7Enumeracoes_E_Composicao._03Composicao.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp._7Enumeracoes_E_Composicao._05ExercicioProposto.Entities
{
    internal class OrderItem
    {
        public int Quantity { get; set; }
        public double Price { get; set; }
        public Product Product { get; set; }

        public OrderItem(int quantity, double price, Product product) { 
            Quantity = quantity;
            Price = price;
            Product = product;
        }
        public double SubTotal() { 
            return Quantity * Price;
        }

       
    }
}
