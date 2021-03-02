using System;
using System.Collections.Generic;

namespace Market
{
    public class Products :IProduct
    {

        static int _idProduct = 1;

        public Products()
        {
           ProductId = _idProduct++;
        }

        public int ProductId { get;set; }

        public string ProductName { get; set; }

        public int ProductWeight { get;set; }

        public void AddProduct(string productName, int productSize)
        {
            Console.Write("Введите название продукта: ");
            string title = Console.ReadLine();

            Console.Write("Введите вес продукта: ");
            int weight = int.Parse(Console.ReadLine()); 


            Products newProduct = new Products
            {
                ProductName = title,
                ProductWeight = weight
            };
            
           // _issueList.Add(newProduct);
        }

        public void DeleteProduct()
        {
            throw new System.NotImplementedException();
        }

        public void EditProduct()
        {
            throw new System.NotImplementedException();
        }

        public override string ToString()
        {
           // ++_countId;
            return "ID: " + ProductId + "   Name: " + ProductName + " Weight: " + ProductWeight;
        }
    }
}
