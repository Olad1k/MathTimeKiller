using System;

namespace Калкулатор_.net9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.Title = "Калкулатор";

            string str; //вызначаєме текст
            int num1, num2, result; //вызначаєме ціфры
            Console.WriteLine("\t\tДОДАВАНЯ ДВОХ ЧІСЕЛ\n");
            Console.Write("Ввидїть 1. чісло: ");
            str = Console.ReadLine();  //приписуєме введеный текс до переміннойи str
            num1 = Convert.ToInt32(str); /* КОНВЕРТАЦІЯ */

            //інтовӯй переміннуй num1 конвертиме значиння текстовойи прм str
            Console.Write("Ввидїть 2. чісло: ");
            str = Console.ReadLine();
            num2 = Convert.ToInt32(str); /* КОНВЕРТАЦІЯ */
            result = num1 + num2; //надаєме інтовці result резултат додаваня інтовок num1 і num2
            Console.WriteLine("Cумма чісел: " + result); //выводіме реултат

            
        }
    }
}
