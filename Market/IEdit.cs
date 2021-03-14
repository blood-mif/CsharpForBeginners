namespace Market
{
   public interface IEdit
    {
        public bool EditWindow(int id, string newName, int newWeight);
        public bool EditProduct(int id, string newName, int newWeight,decimal newPrice);
        public bool AddProductOnWindow(int idWindow, int idProduct);
        public bool DeleteProductFromWindow(int idWindow, int idProduct);
    }
}
