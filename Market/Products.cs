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



        public void AddProduct()
        {


            Console.Write("Введите название продукта: ");
            string _title = Console.ReadLine();

            Console.Write("Введите вес продукта: ");
            int _weight = int.Parse(Console.ReadLine()); 


            Products product = new Products
            {
                ProductName = _title,
                ProductWeight = _weight
            };


        }



        public void DeleteProduct()
        {
            throw new System.NotImplementedException();
        }

        public void EditProduct()
        {
            throw new System.NotImplementedException();
        }

        public void ShowProduct(string productName, int productWeight)
        {
            List<Products> product = new List<Products>();
            foreach (var item in product)
            {
                Console.WriteLine(item);
            }
        }

        public override string ToString()
        {
           // ++_countId;
            return "ID: " + ProductId + "   Name: " + ProductName + " Weight: " + ProductWeight;
        }
    }
}
