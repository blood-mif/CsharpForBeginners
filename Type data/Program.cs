using System;
using System.Text;

namespace Mentor_1 //типы данных
{
    class Program
    {

        static void Main(string[] args)
        {

            byte byteValue = 255; //хранит целое число от 0 до 255 и занимает 1 байт
            sbyte sbyteValue = 100;// хранит целое число от -128 до 127 и занимает 1 байт
            short shortNumber = 122; // хранит целое число от -32768 до 32767 и занимает 2 байта.
            ushort ushortValue = 345; // хранит целое число от 0 до 65535 и занимает 2 байта.
            int number = 7; //хранит целое число от -2147483648 до 2147483647 и занимает 4 байта.
            uint uintValue = 555; //хранит целое число от 0 до 4294967295 и занимает 4 байта.
            long longNumber = 1111222233334444; //хранит целое число от –9 223 372 036 854 775 808 до 9 223 372 036 854 775 807 и занимает 8 байт
            ulong ulongValue = 123443; // хранит целое число от 0 до 18 446 744 073 709 551 615 и занимает 8 байт.
            
            float floatValue = 21.3f; //хранит число с плавающей точкой от -3.4*10^38 до 3.4*10^38 и занимает 4 байта. 
            double doubleValue = 0.1245;//хранит число с плавающей точкой от ±5.0*10^-324 до ±1.7*10^308 и занимает 8 байта
            decimal decimalValue = 321.2300M; //хранит десятичное дробное число. Если употребляется без десятичной запятой, имеет значение от ±1.0*10^-28 до ±7.9228*10^28, может хранить 28 знаков после запятой и занимает 16 байт. 
            
            bool boolValue = false; //хранит значение true или false 
           
            string stringValue = "Hi"; //хранит набор символов Unicode
            char chatValue = '*'; //хранит одиночный символ в кодировке Unicode и занимает 2 байта

            object objectVaule = "fdsf"; //может хранить значение любого типа данных и занимает 4 байта на 32 - разрядной платформе и 8 байт на 64 - разрядной платформ
            object objectVaule2 = 4444;
            object objectVaule3 = 0.32145;

            Console.WriteLine(shortNumber * number);
            Console.WriteLine(longNumber / shortNumber);
            Console.WriteLine(floatValue + doubleValue);
            Console.WriteLine(byteValue - sbyteValue);
            Console.WriteLine(ushortValue % number);
            Console.WriteLine(doubleValue);
            Console.WriteLine(decimalValue);
            Console.WriteLine(byteValue>sbyteValue);
            Console.WriteLine(uintValue == ulongValue);
            Console.WriteLine(number ^ shortNumber);
            Console.WriteLine(0 < (shortNumber * number));
            Console.WriteLine(stringValue);
            Console.WriteLine(chatValue);
            /*Логические операторы
         

            &&        Сокращённое И     (все параметры,если первый оперант удолетворяет условия, второй и далее не рассматривают, так шустрее)
            ||        Сокращённое ИЛИ   (хотя бы один из параметров)
            &         И                 (проверяют все условия, даже если первый оперант уже НЕ удолетворяет условия,тормозят систему)
            |         ИЛИ               (проверяют все условия, даже если первый оперант уже удолетворяет условия,тормозят систему)
            !         НЕ (унарный) 
             */

            bool isHightTemperature = true;
            bool hasNoCooling = true;
            int fanSpeed = 3000;
            bool hasNoCooling1 = fanSpeed <= 0;

            if (isHightTemperature && hasNoCooling)
            {
                Console.WriteLine("Угроза перегрева!!! =&&");
            }
            if (isHightTemperature || hasNoCooling1)
            {
                Console.WriteLine("Угроза перегрева!!! =||");
            }
            if (isHightTemperature | hasNoCooling1)
            {
                Console.WriteLine("Угроза перегрева!!! =|");
            }
            if (isHightTemperature & hasNoCooling1)
            {
                Console.WriteLine("Угроза перегрева!!! =&");
            }

        }
    }
}
