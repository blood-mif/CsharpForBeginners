using System;

namespace Консольный_калькулятор_switch
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                double firstValue;
                double secondValue;
                string str;
                bool answer;



                try
                {
                    Console.WriteLine("Enter first number");
                    firstValue = double.Parse(Console.ReadLine());

                    Console.WriteLine("Enter second number");
                    secondValue = double.Parse(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.WriteLine("Warring! use another format");
                    Console.ReadLine();
                    continue;

                }




                Console.WriteLine("Choose operand: + - * / ");
                str = Console.ReadLine();
                switch (str)
                {
                    case "+":
                        double res = firstValue + secondValue;
                        Console.WriteLine(firstValue + "+" + secondValue + "=" + res);
                        break;
                    case "-":
                        double res1 = firstValue - secondValue;
                        Console.WriteLine(firstValue + "-" + secondValue + "=" + res1);
                        break;
                    case "*":
                        double res2 = firstValue * secondValue;
                        Console.WriteLine(firstValue + "*" + secondValue + "=" + res2);
                        break;
                    case "/":
                        if (secondValue == 0)
                        {
                            Console.WriteLine("На ноль делить нельзя!");
                            Console.ReadLine();
                            continue;
                        }
                        double res3 = firstValue / secondValue;
                        Console.WriteLine(firstValue + "/" + secondValue + "=" + res3);
                        break;
                    default:
                        Console.WriteLine("Warring! You muse choose another symbol");
                        Console.ReadLine();
                        break;
                }
                Console.ReadKey();
            }


        }
    }
}
