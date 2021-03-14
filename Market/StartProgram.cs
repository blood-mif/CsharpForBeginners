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
        public const string SHOW_PRODUCT_ON_WINDOW = "5";
        public const string ADD_PRODUCT_TO_WINDOW = "6";
        public const string DELETE_PRODUCT_FROM_WINDOW = "7";
        public const string SHOW_PRODUCT_LIST = "8";
        public const string ADD_PRODUCT = "9";
        public const string EDIT_PRODUCT = "10";
        public const string DELETE_PRODUCT = "11";
        public const string EXIT = "x";
    }

    public class StartProgram
    {
        IMarketOperations marketOperations = new Market();

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

        private decimal SetPrice(string text)
        {
            var num = 0m;
            var inText = text;

            while (decimal.TryParse(inText, out num) == false)
            {
                inText = GetValue("Incorrect text,try again");
            }
            return num;
        }

        private void ShowWindow()
        {
            Console.WriteLine($"{"ID :",-15}{"Name:",-13}{"MaxWeight:",-20}{"CreateDate:",+10 }");
            int indexItem = 1;
            foreach (var item in marketOperations.ShowAllWindows())
            {
                Console.WriteLine($"{indexItem++,-10} {item.Name,-20} {item.Weight,-10}{item.CreationDateWindow,-10} ");
            }
        }

        private void ShowProducts()
        {
            Console.WriteLine($"{"ID :",-10}{"Name:",-10}{"Weight:",-10}{"Price:",-10}");
            int indexProduct = 1;
            foreach (var item in marketOperations.ShowProductList())
            {
                Console.WriteLine(indexProduct++ + "\t" + item.Text);
            }
        }

        public void Start()
        {
            //Дефолтное создание витрин
            marketOperations.AddWindow("Window_Name1", 9);
            marketOperations.AddWindow("Window_Name2", 17);
            marketOperations.AddWindow("Window_Name3", 4);

            marketOperations.AddProduct("Product_1", 1, 100);
            marketOperations.AddProduct("Product_2", 2, 200);
            marketOperations.AddProduct("Product_3", 3, 300);

            marketOperations.AddProductOnWindow(1, 1);
            marketOperations.AddProductOnWindow(1, 1);
            marketOperations.AddProductOnWindow(1, 3);
            marketOperations.AddProductOnWindow(1, 2);

            Console.Clear();


            bool isContinue = true;

            while (isContinue)
            {
                Console.WriteLine("1  - Вывести список витрин");
                Console.WriteLine("2  - Добавить витрину");
                Console.WriteLine("3  - Редактировать витрину");
                Console.WriteLine("4  - Удалить витрину");
                Console.WriteLine("5  - Показать продукты на витрине");
                Console.WriteLine("6  - Добавить продукт на витрину");
                Console.WriteLine("7  - Удалить продукт с витрины");
                Console.WriteLine("8  - Вывести список продуктов");
                Console.WriteLine("9  - Добавить продукт");
                Console.WriteLine("10 - Редактировать продукт");
                Console.WriteLine("11 - Удалить продукт");
                Console.WriteLine("x  - Выход из программы");

                string operation = Console.ReadLine();

                switch (operation.ToLower())
                {
                    case DisplayOperations.SHOW_WINDOW_LIST:
                        ShowWindow();
                        break;

                    case DisplayOperations.ADD_NEW_WINDOW:
                        marketOperations.AddWindow
                        (GetValue("Введите имя ветрины"), SetValue(GetValue("Введите вместимость витрины")));
                        break;

                    case DisplayOperations.EDIT_WINDOW:
                        marketOperations.EditWindow((SetValue(GetValue("Введите id витрины"))), GetValue("Введите имя ветрины"), SetValue(GetValue("Введите вместимость витрины")));
                        break;

                    case DisplayOperations.DELETE_WINDOW:
                        marketOperations.DeleteWindow(SetValue(GetValue("Введите id витрины")));
                        break;

                    case DisplayOperations.SHOW_PRODUCT_ON_WINDOW:
                        marketOperations.ShowProductsOnWindow(SetValue(GetValue("Введите id витрины")));
                        break;

                    case DisplayOperations.ADD_PRODUCT_TO_WINDOW:
                        marketOperations.AddProductOnWindow(SetValue(GetValue("Введите id витрины")), SetValue(GetValue("Введите id продукта")));
                        break;

                    case DisplayOperations.DELETE_PRODUCT_FROM_WINDOW:
                        marketOperations.DeleteProductFromWindow(SetValue(GetValue("Введите id витрины")), SetValue(GetValue("Введите id продукта")));
                        break;

                    case DisplayOperations.SHOW_PRODUCT_LIST:
                        ShowProducts();
                        break;

                    case DisplayOperations.ADD_PRODUCT:
                        marketOperations.AddProduct(GetValue("Введите имя продукта"), SetValue(GetValue("Введите вес продукта")), SetPrice(GetValue("Введите цену")));
                        break;

                    case DisplayOperations.EDIT_PRODUCT:
                        marketOperations.EditProduct(SetValue(GetValue("Введите id продукта")), GetValue("Введите имя продукта"), SetValue(GetValue("Введите вес продукта")), SetValue(GetValue("Введите цену продукта")));
                        break;

                    case DisplayOperations.DELETE_PRODUCT:
                        marketOperations.DeleteProduct(SetValue(GetValue("Введите id продукта")));
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
                    Console.WriteLine();
                    Console.WriteLine("Press any key ");
                    Console.ReadKey();
                    Console.Clear();
                }
            }
        }
    }
}
