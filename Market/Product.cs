using System;
using System.Collections.Generic;
using System.Linq;

namespace Market
{
    public class Product : IItem
    {
        public Product(string name, int weight, decimal price)
        {
            Name = name;
            Weight = weight;
            Price = price;
        }
        public string Name { get; set; }
        public int Weight { get; set; }
        public decimal Price { get; set; }
        // Text для вывода товаров в консоль
        public string Text => $"{Name,-15}{Weight,-15}{Price,-15}";

    }
}
