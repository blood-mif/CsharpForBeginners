using System;
using System.Collections.Generic;


namespace Market
{
    public static class Operations
    {
        public const string SHOW_WINDOW_LIST = "1";
        public const string ADD_NEW_WINDOW = "2";
        public const string EDIT_WINDOW = "3";
        public const string DELETE_WINDOW = "4";
        public const string ADD_PRODUCT_TO_WINDOW = "5";
        public const string DELETE_PRODUCT_FROM_WINDOW = "6";
        public const string SHOW_PRODUCT_LIST = "7";
        public const string ADD_PRODUCT = "8";
        public const string EDIT_PRODUCT = "9";
        public const string DELETE_PRODUCT = "10";
        public const string EXIT = "x";
    }

    public class StartProgram
    {

        
        public void Start()
        {
            List<Products> product = new List<Products>(4);
            Console.WriteLine("Hi");
            
            product.Add(new Products() { ProductName = "crank arm", ProductWeight = 1234,  });
            product.Add(new Products() { ProductName = "111", ProductWeight = 321, });





              

               bool isContinue = true;

               while (isContinue)
               {
                   Console.WriteLine("1  - Вывести список витрин");
                   Console.WriteLine("2  - Добавить витрину");
                   Console.WriteLine("3  - Редактировать витрину");
                   Console.WriteLine("4  - Удалить витрину");
                   Console.WriteLine("5  - Добавить продукт на витрину");
                   Console.WriteLine("6  - Удалить продукт с витрины");
                   Console.WriteLine("7  - Вывести список продуктов");
                   Console.WriteLine("8  - Добавить продукт");
                   Console.WriteLine("9  - Редактировать продукт");
                   Console.WriteLine("10 - Удалить продукт");
                   Console.WriteLine("x  - Выход из программы");

                   string operation = Console.ReadLine();

                   switch (operation.ToLower())
                   {
                       case Operations.SHOW_WINDOW_LIST:
                        ShowWindowList();
                           break;

                       case Operations.ADD_NEW_WINDOW:
                        AddWindow();
                           break;

                       case Operations.EDIT_WINDOW:
                        EditWindow();
                           break;

                       case Operations.DELETE_WINDOW:
                        DeleteWindow();
                           break;

                       case Operations.ADD_PRODUCT_TO_WINDOW:
                        AddProductToWindow();
                           break;

                       case Operations.DELETE_PRODUCT_FROM_WINDOW:
                        DeleteProductFromWindow();
                           break;

                       case Operations.SHOW_PRODUCT_LIST:
                           ShowProductList();
                           break;

                       case Operations.ADD_PRODUCT:
                           AddProduct();
                           break;

                       case Operations.EDIT_PRODUCT:
                           EditProduct();
                           break;

                       case Operations.DELETE_PRODUCT:
                           DeleteProduct();
                           break;

                    case Operations.EXIT:
                           isContinue = false;
                           break;

                       default:
                           Console.WriteLine("Такой команды нет! " + operation);
                           break;
                   }

                   if (isContinue)
                   {
                       Console.WriteLine("Press any key ");
                       Console.ReadKey();
                       Console.Clear();
                   }

               }
            
        }


    }
}
