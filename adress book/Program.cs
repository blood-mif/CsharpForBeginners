using System;

namespace Mentor_2_2 //адресная книга
{
    class Program
    {
        static void VienBook(string[] names,string[] phoneNumbers)
        {
            for (int i = 0; i < names.Length; i++)
            {
                Console.Write("Name " + names[i] + "\tphone " + phoneNumbers[i]);
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
            string[] names = { "Vasiy", "Ivan", "Maria", "Jon" };
            string[] phoneNumbers = { "8-800-555-44-33","495-42-13","8-916-32-54","777-32-54"};

            Console.WriteLine("Хотите добавить контакт ? press \"add\"");
            Console.WriteLine("Хотите удалить контакт ? press \"delete\"");
            Console.WriteLine("Хотите посмотреть контакты ? press \"show\"");
            
            string chooseValue = Console.ReadLine();
            
            if (chooseValue == "add")
            {
                string[] newNames = new string[names.Length+1];
                Console.WriteLine("Введите новое имя");
                newNames[newNames.Length - 1] = Console.ReadLine();
                for (int i = 0; i < names.Length; i++)
                {
                    newNames[i] = names[i];
                }
                names = newNames;
                string[] newPhoneNumbesr = new string[phoneNumbers.Length + 1];
                Console.WriteLine("Введите новый номер");
                newPhoneNumbesr[newPhoneNumbesr.Length - 1] = Console.ReadLine();
                for (int i = 0; i < phoneNumbers.Length; i++)
                {
                    newPhoneNumbesr[i] = phoneNumbers[i];
                }
                phoneNumbers = newPhoneNumbesr;

                Console.WriteLine("Сейчас ваша записаная книга выглядит так:");
                VienBook(names, phoneNumbers);
            }

            else if (chooseValue == "delete")
            {
                Console.WriteLine("Выберете номер записи");
                Console.WriteLine("номер 0 " + names[0]);
                Console.WriteLine("номер 1 " + names[1]);
                Console.WriteLine("номер 2 " + names[2]);
                Console.WriteLine("номер 3 " + names[3]);

                int indexValue = int.Parse(Console.ReadLine());


                string[] newNames = new string[names.Length - 1];
                for (int i = 0; i < newNames.Length; i++)
                {
                    if (indexValue == i)
                    {

                        for (int j = i; j < newNames.Length; j++)
                        {
                            newNames[i] = names[i + 1];
                            i++;
                        }
                        break;
                    }
                    newNames[i] = names[i];
                }
                names = newNames;

                string[] newPhoneNumbesr = new string[phoneNumbers.Length - 1];
                for (int i = 0; i < newPhoneNumbesr.Length; i++)
                {
                    if (indexValue == i)
                    {

                        for (int j = i; j < newPhoneNumbesr.Length; j++)
                        {
                            newPhoneNumbesr[i] = phoneNumbers[i + 1];
                            i++;
                        }
                        break;
                    }
                    newPhoneNumbesr[i] = phoneNumbers[i];
                }
                phoneNumbers = newPhoneNumbesr;

                Console.WriteLine("Сейчас ваша записаная книга выглядит так:");
                VienBook(names, phoneNumbers);

            }
            else if (chooseValue == "show")
            {
                Console.WriteLine("Сейчас ваша записаная книга выглядит так:");
                VienBook(names, phoneNumbers);
            }
            else
                Console.WriteLine("вы написали неверную команду");
        }
    }
}
