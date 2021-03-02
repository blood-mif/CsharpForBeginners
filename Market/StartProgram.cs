using System;
using System.Collections.Generic;
using System.Text;

namespace Market
{
    class StartProgram
    {
        
        public void Start()
        {
            List<Products> product = new List<Products>(4);
            Console.WriteLine("Hi");
            
            product.Add(new Products() { ProductName = "crank arm", ProductWeight = 1234,  });
            product.Add(new Products() { ProductName = "111", ProductWeight = 321, });

            foreach (var item in product)
            {
                Console.WriteLine(item);
            }


            /*
            bool isContinue = true;

            while (isContinue)
            {
                Console.WriteLine("1 - Вывести список витрин");
                Console.WriteLine("2 - Добавить витрину");
                Console.WriteLine("3 - Удалить витрину");
                Console.WriteLine("4 - Редактировать задачу");
                Console.WriteLine("5 - Отметить задачу как выполненную");
                Console.WriteLine("x - Выход из программы");

                string operation = Console.ReadLine();

                switch (operation.ToLower())
                {
                    case Operations.SHOW_ISSUES_LIST:
                        PrintIssues();
                        break;

                    case Operations.ADD_NEW_ISSUE:
                        CreateNewIssues();
                        break;

                    case Operations.DELETE_ISSUE:
                        DeleteIssue();
                        break;

                    case Operations.EDIT_ISSUE:
                        EditIssue();
                        break;

                    case Operations.SET_ISSUE_AS_DONE:
                        EditStatusIssue();
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
*/
        }

    }
}
