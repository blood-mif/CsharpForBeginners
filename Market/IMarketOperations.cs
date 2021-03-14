using System.Collections.Generic;

namespace Market
{
    interface IMarketOperations : IEdit
    {
        List<Window> ShowAllWindows();
        List<Product> ShowProductList();
        bool DeleteWindow(int item);
        bool AddWindow(string name, int weight);
        bool DeleteProduct(int id);
        public bool AddProduct(string name, int weight, decimal price);
        public bool ShowProductsOnWindow(int idWindow);
    }

}
