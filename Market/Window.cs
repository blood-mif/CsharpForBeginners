using System;
using System.Collections.Generic;
using System.Linq;

namespace Market
{
    public class Window : IOperations, IItem, IEdit
    {
        static int id = 1; 
        public Window(string name, int weight)
            {
            Id = id++;
            Name = name;
            Weight = weight;
            CreationDateWindow = DateTime.Now;
            }

        public List<Product> Products = new List<Product>();

        public DateTime CreationDateWindow { get; set; }
        public string Name { get; set; }
        public int Weight { get; set; }
        public int Id { get; set; }


        public bool DeleteItem(int id)
        {

            var removeItem = Products.Where(product => product.Id == id).ToList();
            if (removeItem.Count == 0)
            {
                return false;
            }

            //проверить 
            //else
            //    removeItem[0] = null;

            Products.Remove(removeItem[0]);
            return true;
        }

        public bool EditItem(int id, string name, int weight)
        {

            return false;

        }

        public bool AddItem(string name,int weightItem)
        {
            var coureWeight = Products.Select(rrr => rrr.Weight).Sum();
            if (coureWeight + weightItem > Weight)
            {
                return false;
            }
            var item = new Product(name, weightItem);
            Products.Add(item);
                return true;
        }

        public void ShowWindow()
        {


        }

    }
}
