namespace Market
{
    interface IOperations
    {


        bool DeleteWindow(int item);
        bool AddWindow(string name, int weight);
        bool EditWindow(int id, string newName, int newWeight);

        
        bool EditProduct(int id, string newName, int newWeight);
        bool DeleteProduct(int id);






    }
}
