using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Market
{
    public class Market : IOperations, IEdit
    {

        public List<Window> Windows = new List<Window>() ;
       public List<Product> ProductList = new List<Product>();


        public bool AddItem(string name, int maxWeightWindow)
        {
            var window = new Window(name, maxWeightWindow);
            Windows.Add(window);
            return true;
        }

        public bool DeleteItem(int id)
        {

            var removeWindonw = Windows.Where(window => window.Id == id).ToList();
            if (removeWindonw.Count == 0)
            {
                return false;
            }

            if (0 < removeWindonw[0].Products.Select(coureWeight => coureWeight.Weight).Sum())
            {
                return false;
            }

            Windows.Remove(removeWindonw[0]);
            return true;

        }

        public bool EditItem(int id, string newName, int newWeight)
        {
            
            var editWindonw = Windows.Where(window => window.Id == id).ToList();
            if (editWindonw.Count == 0)
            {
                return false;
            }

           if (newWeight<=editWindonw[0].Products.Select(coureWeight => coureWeight.Weight).Sum())
            {
                return false;
            }

            
            int indexItem = Windows.IndexOf(editWindonw[0]);

            Windows[indexItem].Name = newName;
            Windows[indexItem].Weight = newWeight;


            return true;
        }
    }
}
