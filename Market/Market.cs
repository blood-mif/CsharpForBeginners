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
          
            
            throw new NotImplementedException();
        }

        public bool EditItem(int id)
        {
            throw new NotImplementedException();
        }
    }
}
