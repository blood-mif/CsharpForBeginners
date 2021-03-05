namespace Market
{
   public interface IEdit
    {
        bool EditWindow(int id, string newName, int newWeight);
        bool EditProduct(int id, string newName, int newWeight);
    }
}
