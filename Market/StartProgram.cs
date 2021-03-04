using System;
using System.Collections.Generic;
using System.Linq;


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

        private void ShowProducts()
        {
            Console.WriteLine($"{"ID :",-10}{"Name:",-10}{"Weight:",-10}");
            foreach (var item in market.ProductList)
            {
                Console.WriteLine($"{item.Id,-10} {item.Name,-10} {item.Weight,-10} ");
            }
        }

        public void Start()
        {

            //Дефолтное создание витрин
            market.Windows = new List<Window>
                
            {
                new Window("Name1",23),
                new Window("Name2",13),
                new Window("Name3",4),

            };

            //Дефолтное создание продуктов
            market.ProductList = new List<Product>
            {
                new Product("Product_1", 1),
                new Product("Product_2", 3),
                new Product("Product_3", 2),
            };


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
                        market.AddItem(GetValue("Введите имя ветрины"), SetValue(GetValue("Введите вместимость витрины")));
                        break;

                       case DisplayOperations.EDIT_WINDOW:
                      market.EditItem((SetValue(GetValue("Введите id витрины"))),GetValue("Введите имя ветрины"), SetValue(GetValue("Введите вместимость витрины")));
                        break;

                       case DisplayOperations.DELETE_WINDOW:
                        market.DeleteItem(SetValue(GetValue("Введите id витрины")));
                           break;

                       case DisplayOperations.ADD_PRODUCT_TO_WINDOW:
                   //     AddProductToWindow();
                           break;

                       case DisplayOperations.DELETE_PRODUCT_FROM_WINDOW:
                     //   DeleteProductFromWindow();
                           break;

                       case DisplayOperations.SHOW_PRODUCT_LIST:
                        ShowProducts();
                        break;

                       case DisplayOperations.ADD_PRODUCT:
                        market.ProductList.Add(new Product(GetValue("Введите имя продукта"), SetValue(GetValue("Введите вес продукта"))));
                        break;

                       case DisplayOperations.EDIT_PRODUCT:

                           break;

                       case DisplayOperations.DELETE_PRODUCT:
                        var ss= SetValue(GetValue("Введите id продукта"));
                        var ss1 = market.ProductList.Where(dat => dat.Id == ss).ToList()[0];
                        var ss2 = market.ProductList.IndexOf(ss1);
                        //market.ProductList.Remove(ss1);
                        market.ProductList.RemoveAt(ss2);
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
