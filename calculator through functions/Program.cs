using System;
using System.Linq;

namespace calculator 
{
    class Program
    {

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

        static void getValue(ref double value)
        {
            string str;
            bool result;
            str = Console.ReadLine();
            result = double.TryParse(str, out value);

            if (result) { }
            else
            {
                while (result == false)
                { 
                Console.WriteLine("Ошибка ввода числа, попробуйте еще раз, используя только числа");
                    str = Console.ReadLine();
                    result = double.TryParse(str, out value);
                    continue;
            }
        }
            
        }

        static void mathematicalOperation(double firstValue, double secondValue)
        {
            string str = Console.ReadLine();

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

            while (str != "+" && str != "-" && str != "*" && str != "/" )
            {

                Console.WriteLine("Вы ввели не верный символ математической операции, попробуйте еще раз");
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
                    continue;
                }
            }
        }

        static void calculator(double firstValue, double secondValue)
        {
            while (true)
            {

                Console.WriteLine("Введите первое число: ");
                getValue(ref firstValue);


                Console.WriteLine("Введите второе число: ");
                getValue(ref secondValue);

                Console.WriteLine("Введите желаемую операцию: + - * / ");
                mathematicalOperation(firstValue, secondValue);

                Console.ReadKey();
                Console.Clear();
            }
        }

        static void Main(string[] args)
        {
            double firstValue = 0;
            double secondValue = 0;

            calculator(firstValue, secondValue);

        }
    }
}
