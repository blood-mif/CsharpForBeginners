using System;
using System.Collections.Generic;


namespace Market
{
    public static class DisplayOperations
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

        Market market = new Market();

        private string GetValue(string text)
        {
            Console.WriteLine(text);
            return Console.ReadLine();

        }

        private int SetValue(string text)
        {
            var num = 0;
            var inText = text;

            while (int.TryParse(inText, out num) == false)
            {
                inText = GetValue("Incorrect text,try again");
            }

            return num;
        }

        private void ShowWindow()
        {
            Console.WriteLine($"{"ID :",-10}{"Name:",-10}{"Weight:",-10}");
            foreach (var item in market.Windows)
            {
                Console.WriteLine($"{item.Id,-10} {item.Name,-10} {item.Weight,-10} ");
            }
        }

        public void Start()
        {
            List<Product> product = new List<Product>();
              

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
                       case DisplayOperations.SHOW_WINDOW_LIST:

                        ShowWindow();
                           break;

                       case DisplayOperations.ADD_NEW_WINDOW:
                        market.AddItem(GetValue("Введите имя ветрины"), SetValue(GetValue("Введите вес витрины")));
                        break;

                       case DisplayOperations.EDIT_WINDOW:
                      //  EditWindow();
                           break;

                       case DisplayOperations.DELETE_WINDOW:
                        market.DeleteItem(SetValue(GetValue("Введите вес витрины")));
                           break;

                       case DisplayOperations.ADD_PRODUCT_TO_WINDOW:
                   //     AddProductToWindow();
                           break;

                       case DisplayOperations.DELETE_PRODUCT_FROM_WINDOW:
                     //   DeleteProductFromWindow();
                           break;

                       case DisplayOperations.SHOW_PRODUCT_LIST:
                   //        ShowProductList();
                           break;

                       case DisplayOperations.ADD_PRODUCT:
                       //    AddProduct();
                           break;

                       case DisplayOperations.EDIT_PRODUCT:
                      //     EditProduct();
                           break;

                       case DisplayOperations.DELETE_PRODUCT:
                     //      DeleteProduct();
                           break;

                    case DisplayOperations.EXIT:
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
