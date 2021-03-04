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
        public decimal Price { get; set; }

        public List<Product> ProductList = new List<Product>();

        public bool AddItem(string nameProduct,int weightProduct)
        {
            var product = new Product(nameProduct, weightProduct);
            ProductList.Add(product);
            return true;
        }

        public bool DeleteItem(int id)
        {

            var removeProduct = ProductList.Where(product => product.Id == id).ToList();
            if (removeProduct.Count == 0)
            {
                return false;
            }


            ProductList.Remove(removeProduct[0]);
            return true;
        }

        public bool EditItem(int id,string newName, int newWeight)
        {
            var editProduct = ProductList.Where(product => product.Id == id).ToList();
            if (editProduct.Count == 0)
            {
                return false;
            }


            int indexItem = ProductList.IndexOf(editProduct[0]);

            ProductList[indexItem].Name = newName;
            ProductList[indexItem].Weight = newWeight;


            return true;
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
