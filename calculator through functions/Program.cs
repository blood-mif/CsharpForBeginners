using System;

namespace Калькулятор
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string str;
            double firstValue;
            double secondValue;
            bool result;

            static void addition(double firstValue, double secondValue)
            {
                double res = firstValue + secondValue;
                Console.WriteLine("Сложение чисел " + firstValue + " и " + secondValue + " = " + res);
            }

            static void difference(double firstValue, double secondValue)
            {
                double res = firstValue - secondValue;
                Console.WriteLine("Вычитание чисел " + firstValue + " и " + secondValue + " = " + res);
            }

            static void multiplication(double firstValue, double secondValue)
            {
                double res = firstValue * secondValue;
                Console.WriteLine("Умножение чисел " + firstValue + " и " + secondValue + " = " + res);
            }

            static void division(double firstValue, double secondValue)
            {
                while (true)
                {
                    if (secondValue == 0)
                    {
                        Console.WriteLine("На ноль делить нельзя!!!");
                        Console.ReadKey();
                        break;

                    }
                    double res = firstValue / secondValue;
                    Console.WriteLine("Деление чисел чисел = " + firstValue + " и " + secondValue + " = " + res);
                }            
                }



            while (true)
            {

                Console.WriteLine("Введите первое число: ");
                str = Console.ReadLine();
                result = double.TryParse(str, out firstValue);
                if (result)
                {
                }
                else
                {
                    Console.WriteLine("Ошибка ввода второго числа, используйте только числа");
                    Console.ReadLine();
                    continue;
                }

                Console.WriteLine("Введите второе число: ");
                str = Console.ReadLine();
                result = double.TryParse(str, out secondValue);
                if (result)
                {
                }
                else
                {
                    Console.WriteLine("Ошибка ввода второго числа, используйте только числа");
                    Console.ReadLine();
                    continue;
                }

                Console.WriteLine("Введите желаемую операцию: + - * / ");
                str = Console.ReadLine();
                if (str == "+")
                {
                    addition(firstValue, secondValue);
                }

                else if (str == "-")
                {
                    difference(firstValue, secondValue);
                }


                else if (str == "*")
                {
                    multiplication(firstValue, secondValue);
                }

                else if (str == "/")
                {
                    division(firstValue, secondValue);
                }
                else
                {
                    Console.WriteLine("Вы ввели не верный символ математической операции");
                }
                Console.ReadKey();
                Console.Clear();
            }

        }
    }
}
