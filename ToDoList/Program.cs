using System;
using System.Text;

namespace ToDoList
{

    /*
    Список задач:
    + добавить задачу
    + удалить задачу
    + помечать задачу как выполненную
    + редактирование задачи

    Задача:
    + название
    + дата создания
    + статус

    Статусы задачи:
    + новая
    + выполненная
     
    */

    internal class Program
    {
        private static IssueList _issueList;

        private static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            _issueList = new IssueList(4);

            bool isContinue = true;

            while (isContinue)
            {
                Console.WriteLine("1 - Вывести список задач");
                Console.WriteLine("2 - Добавить задачу");
                Console.WriteLine("3 - Удалить задачу");
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
           


        }

        private static void EditStatusIssue()
        {
            int selectedIssueNumber = GetIssueNumber();

            _issueList.EditStatusIssue(selectedIssueNumber);
        }

        private static void DeleteIssue()
        {
            int selectedIssueNumber = GetIssueNumber();
            _issueList.Delete(selectedIssueNumber);
        }

        private static void EditIssue()
        {
            int selectedIssueNumber = GetIssueNumber();

            Console.Write("Введите новое название задачи: ");
            string newTitle = Console.ReadLine();
            _issueList.EditTitle(selectedIssueNumber, newTitle);
        }

        private static void PrintIssues()
        {
            Issue[] issues = _issueList.GetIssues();

            for (int i = 0; i < issues.Length; i++)
            {
                Issue issue = issues[i];
                int issueNumber = (i + 1);

                Console.WriteLine(issueNumber + ") Название: " + issue.Title + " , " + "Статус: " + issue.Status);
            }
        }

        private static void CreateNewIssues()
        {
            Console.Write("Введите название задачи: ");
            string title = Console.ReadLine();

            Issue newIssue = new Issue
            {
                Title = title
            };

            _issueList.Add(newIssue);

        }

        private static int GetIssueNumber()
        {
            Issue[] issues = _issueList.GetIssues();

            for (int i = 0; i < issues.Length; i++)
            {
                Issue issue = issues[i];
                int issueNumber = (i + 1);

                Console.WriteLine(issueNumber + ") Название: " + issue.Title + " , " + "Статус: " + issue.Status);
            }

            bool isSuccess = false;
            int selectedIssueNumber = 0;
            do
            {
                Console.WriteLine("Введите номер задачи: ");
                string userInput = Console.ReadLine();

                isSuccess = int.TryParse(userInput, out selectedIssueNumber);

                if (selectedIssueNumber < 1 || selectedIssueNumber > issues.Length)
                {
                    isSuccess = false;
                    Console.WriteLine("Номер задачи должен быть в диапазоне от 1 до " + issues.Length);
                }



            } while (isSuccess == false);

            return selectedIssueNumber;
        }
    }
}
