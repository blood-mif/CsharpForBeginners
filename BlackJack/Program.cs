using System;

namespace Mentor_2 //21 очко
{
    class Program
    {

        static void Main(string[] args)
        {
            string[] desk = { "2", "3", "4", "5", "6", "7", "8", "9", "10", "V", "D", "K", "T", "2", "3", "4", "5", "6", "7", "8", "9", "10", "V", "D", "K", "T", "2", "3", "4", "5", "6", "7", "8", "9", "10", "V", "D", "K", "T", "2", "3", "4", "5", "6", "7", "8", "9", "10", "V", "D", "K", "T" };
           
            Random random = new Random();

            
            int cartValueUser = 0;
            int yourPoints =0;
            int compPoints =0;

            for (int yourHand = 0; yourHand < 22;)
            {
                string cartValue = desk[random.Next(0, 52)];


                Console.WriteLine("У вас карта " + cartValue);
                if (cartValue == "V" || cartValue == "D" || cartValue == "K")
                {
                    cartValueUser  = 10;
                    yourHand = cartValueUser + yourHand;
                    if (yourHand > 22)
                    {
                        Console.WriteLine("Вы проиграли, у вас перебор " + yourHand);
                        return;
                    }
                }
                
                else if (cartValue =="T")
                {
                    if (yourHand <= 10)
                    {
                        cartValueUser = 11;
                    }
                    else
                    {
                        cartValueUser = 1;
                    }
                    yourHand = cartValueUser + yourHand;
                    if (yourHand > 22)
                    {
                        Console.WriteLine("Вы проиграли, у вас перебор " + yourHand);
                        return;
                    }
                }
                else
                {
                    cartValueUser = int.Parse(cartValue);
                    yourHand = cartValueUser + yourHand;
                    if (yourHand > 22)
                    {
                        Console.WriteLine("Вы проиграли, у вас перебор " + yourHand);
                        return;
                    }
                }
                Console.WriteLine("У вас очков = " + yourHand);

                Console.WriteLine("Взять еще карту? (y/n)");
                string again = Console.ReadLine();
                if (again == "y")
                {
                        continue;
                }
                else
                    {
                        Console.WriteLine("у вас " + yourHand);
                    yourPoints = yourHand;
                    break;
                    
                    }
                
            }
            Console.WriteLine("А теперь ходит комп");
            // Бытые нарушено, random в цикле карждый раз генерится заново, что позволяет появление повторов =(
            for (int compHand = 0; compHand < 16; )
            {
                string cartValue = desk[random.Next(0, 52)];

                if (cartValue == "V" || cartValue == "D" || cartValue == "K")
                {
                    cartValueUser = 10;
                    compHand = cartValueUser + compHand;
                    if (compHand > 22)
                    {
                        Console.WriteLine("Комп проиграл, у него перебор " + compHand);
                        break;
                    }
                }

                else if (cartValue == "T")
                {
                    if (compHand <= 10)
                    {
                        cartValueUser = 11;
                    }
                    else
                    {
                        cartValueUser = 1;
                    }
                    compHand = cartValueUser + compHand;
                    if (compHand > 22)
                    {
                        Console.WriteLine("Комп проиграл, у него перебор " + compHand);
                        break;
                    }
                }
                else
                {
                    cartValueUser = int.Parse(cartValue);
                    compHand = cartValueUser + compHand;
                    if (compHand > 22)
                    {
                        Console.WriteLine("Комп проиграл, у него перебор " + compHand);
                        break;
                    }
                }
                compPoints = compHand;
                Console.WriteLine("У компа карта "+cartValue +" в сумме очков "+ compPoints);
            }
            if (yourPoints >= compPoints & yourPoints < 22)
            {
                Console.WriteLine("Вы победили");
            }
            if (yourPoints < compPoints & compPoints < 22)
            {
                Console.WriteLine("Вы проиграли");
            }

        }
    }
}
