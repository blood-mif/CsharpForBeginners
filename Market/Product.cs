using System;
using System.Collections.Generic;
using System.Linq;

namespace Market
{
    public class Product : IItem, IEdit
    {
        static int id = 1;

        public Product(string name, int weight)
        {
           Id = id++;
            Name = name;
            Weight = weight;
        }

        public string Name { get; set; }
        public int Weight { get; set; }
        public int Id { get; set; }

        public bool AddItem<T>(T item)
        {
            throw new NotImplementedException();
        }

        public bool DeleteItem<T>(T item)
        {
            throw new NotImplementedException();
        }

        public bool EditItem<T>(T item)
        {
            throw new NotImplementedException();
        }

        public bool EditItem(int item)
        {
            throw new NotImplementedException();
        }




        //public int ProductId { get;set; }

        //public string ProductName { get; set; }

        //public int ProductWeight { get;set; }



        //public void AddProduct()
        //{


        //    Console.Write("Введите название продукта: ");
        //    string _title = Console.ReadLine();

        //    Console.Write("Введите вес продукта: ");
        //    int _weight = int.Parse(Console.ReadLine()); 


        //    Products product = new Products
        //    {
        //        ProductName = _title,
        //        ProductWeight = _weight
        //    };


        //}



        //public void DeleteProduct()
        //{
        //    throw new System.NotImplementedException();
        //}

        //public void EditProduct()
        //{
        //    throw new System.NotImplementedException();
        //}

        //public void ShowProduct(string productName, int productWeight)
        //{
        //    List<Products> product = new List<Products>();
        //    foreach (var item in product)
        //    {
        //        Console.WriteLine(item);
        //    }
        //}

        //public void ShowProductList(string productName, int productWeight)
        //{
        //    throw new NotImplementedException();
        //}

        //public override string ToString()
        //{
        //   // ++_countId;
        //    return "ID: " + ProductId + "   Name: " + ProductName + " Weight: " + ProductWeight;
        //}
    }
}
