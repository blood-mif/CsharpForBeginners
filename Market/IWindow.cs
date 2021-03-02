namespace Market
{
    interface IWindow
    {
        void ShowWindow();

        void AddWindow(string windowName, int windowSize );

        void EditWindow(int windowId);

        void DeleteWindow(int windowId);

        void AddProductToWindow(int productId);

        void DeleteProductFromWindow(int productId);
    }
}
