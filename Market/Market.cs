using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Market
{
    public class Market : IMarketOperations, IEdit
    {
        private List<Window> Windows;
        private List<Product> ProductList;

        public Market()
        {
            Windows = new List<Window>();
            ProductList = new List<Product>();
        }

        public List<Window> ShowAllWindows()
        {
            return Windows;
        }
        public List<Product> ShowProductList()
        {
            return ProductList;
        }
        public bool AddWindow(string name, int maxWeightWindow)
        {
            var window = new Window(name, maxWeightWindow);
            Windows.Add(window);
            Console.WriteLine("Витрина создана");
            return true;
        }
        public bool DeleteWindow(int id)
        {
            var indexDelete = id - 1;

            if (0 < Windows.Count && Windows.Count <= indexDelete)
            {
                Console.WriteLine("Вы ввели не правильный id");
                return false;
            }

            if (0 < Windows[indexDelete].Products.Select(coureWeight => coureWeight.Weight).Sum())
            {
                Console.WriteLine("Нельзя удалить витрину, если на ней что то есть");
                return false;
            }

            Windows.RemoveAt(indexDelete);
            Console.WriteLine("Витрина удалена");
            return true;

        }
        public bool EditWindow(int id, string newName, int newWeight)
        {

            var indexEdit = id - 1;

            if (0 < Windows.Count && Windows.Count <= indexEdit)
            {
                Console.WriteLine("Вы ввели не правильный id");
                return false;
            }

            if (newWeight < 0)
            {
                Console.WriteLine("Вместимость витрины не может быть отрицательной ");
                return false;
            }

            var sumAllProductOnWindow = Windows[indexEdit].Products.Select(coureWeight => coureWeight.Weight).Sum();
            /*
             Как грамотнее написать?
             Объявить переменную равную сумме продуктов на витрине, и сначала сделать проверку есть ли продукты вообще на витрине,
            чтоб не делать проверку на вместимость в случае true
            или сразу делать проверку с подсчётом суммы и проверки соотношения?
             */
            if (sumAllProductOnWindow != 0 )
            {
                if (newWeight < sumAllProductOnWindow)
                {
                    Console.WriteLine("Вместимость витрины не может быть меньше, чем обьём занимаемых её товаров ");
                    return false;
                }
            }

            Windows[indexEdit].Name = newName;
            Windows[indexEdit].Weight = newWeight;

            Console.WriteLine("Витрина изменена");
            return true;
        }
        public bool AddProduct(string name, int weight, decimal price)
        {
            var item = new Product(name, weight, price);
            ProductList.Add(item);
            return true;
        }
        public bool DeleteProduct(int id)
        {

            var indexDelete = id - 1;
            if (0 < ProductList.Count && ProductList.Count <= indexDelete)
            {
                Console.WriteLine("Вы ввели не правильный id");
                return false;
            }

            ProductList.RemoveAt(indexDelete);
            Console.WriteLine("Продукт удалён");
            return true;
        }
        public bool EditProduct(int id, string newName, int newWeight, decimal newPrice)
        {
            var indexEdit = id - 1;
            if (0 < ProductList.Count && ProductList.Count <= indexEdit)
            {
                Console.WriteLine("Вы ввели не правильный id");
                return false;
            }

            ProductList[indexEdit].Name = newName;
            ProductList[indexEdit].Weight = newWeight;
            ProductList[indexEdit].Price = newPrice;
            Console.WriteLine("Продукт изменён");
            return true;
        }
        public bool AddProductOnWindow(int idWindow, int idProduct)
        {
            var indexWindow = idWindow - 1;

            if (0 < Windows.Count && Windows.Count <= indexWindow)
            {
                Console.WriteLine("Вы ввели не правильный id");
                return false;
            }

            var indexProduct = idProduct - 1;
            if (0 < ProductList.Count && ProductList.Count <= indexProduct)
            {
                Console.WriteLine("Вы ввели не правильный id");
                return false;
            }

            var coureWeight = Windows[indexWindow].Products.Select(rrr => rrr.Weight).Sum();

            if (coureWeight + ProductList[indexProduct].Weight > Windows[indexWindow].Weight)
            {
                Console.WriteLine("Данный товар нельзя добавить на витрину из за ограничения по весу");
                return false;
            }

            Windows[indexWindow].AddProductOnWindow(ProductList[indexProduct].Name, ProductList[indexProduct].Weight, ProductList[indexProduct].Price);
            Console.WriteLine("Продукт добавлен на витрину");
            return true;
        }
        public bool DeleteProductFromWindow(int idWindow, int idProduct)
        {
            var indexWindow = idWindow - 1;

            if (0 < Windows.Count && Windows.Count <= indexWindow)
            {
                Console.WriteLine("Вы ввели не правильный id");
                return false;
            }

            var indexProduct = idProduct - 1;
            if (0 < Windows[indexWindow].Products.Count && Windows[indexWindow].Products.Count <= indexProduct)
            {
                Console.WriteLine("Вы ввели не правильный id");
                return false;
            }
            Windows[indexWindow].Products.RemoveAt(indexProduct);

            Console.WriteLine("Продукт удалён с витрины");
            return true;
        }
        public bool ShowProductsOnWindow(int idWindow)
        {
            var indexProductOnWindow = idWindow - 1;

            if (0 < Windows.Count && Windows.Count <= indexProductOnWindow)
            {
                Console.WriteLine("Вы ввели не правильный id");
                return false;
            }

            int indexNumber = 1;
            Console.WriteLine($"{"ID ",-10}{"Name:",-10}{"Weight:",-10}{"Price:",+13}");
            foreach (var item in Windows[indexProductOnWindow].Products)
            {
                Console.WriteLine("Id :" + indexNumber + "\t" + item.Text);
                indexNumber++;
            }

            return true;
        }
    }
}
