using System;
using System.Collections.Generic;
using System.Linq;

namespace Market
{
    public class Window : IItem
    {
        public Window(string name, int weight)
            {
            Name = name;
            Weight = weight;
            CreationDateWindow = DateTime.Now;
            }

        public List<Product> Products = new List<Product>();

        public DateTime CreationDateWindow { get; set; }
        public string Name { get; set; }
        public int Weight { get; set; }


        //Создать продукт на витрине
        public bool AddProductOnWindow(string name, int weightItem, decimal price)
        {
            var coureWeight = Products.Select(rrr => rrr.Weight).Sum();
            if (coureWeight + weightItem > Weight)
            {
                return false;
            }
            var item = new Product(name, weightItem, price);
            Products.Add(item);
            return true;
        }




    }
}
