namespace Market
{
    interface IProduct
    {
        void ShowProductList(string productName,int productWeight);

        void EditProduct();

        void DeleteProduct();

        void AddProduct();
    }
}
