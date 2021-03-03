using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Market
{
    public class Market : IOperations, IEdit
    {

        public List<Window> Windows = new List<Window>() ;

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

            Windows.Remove(removeWindonw[0]);
            return true;

        }

        public bool EditItem(int id)
        {
            var editWindonw = Windows.Where(window => window.Id == id).ToList();
            if (editWindonw.Count == 0)
            {
                return false;
            }

            Windows.Remove(editWindonw[0]);
            return true;
        }
    }
}
