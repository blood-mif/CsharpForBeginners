using System;
using System.Collections.Generic;
using System.Text;

namespace Market
{
     public interface IItem
    {
        string Name { get; set; }
        int Weight { get; set; }
    }
}
