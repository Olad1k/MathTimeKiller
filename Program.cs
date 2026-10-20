using System;

namespace Калкулатор_.net9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.Title = "Калкулатор";

         /* // ==========================================
            // СЦЕНА 1: ИГРОК ПОБЕЖДАЕТ (Применяем инкремент ++)
            // ==========================================*/

            string str; //вызначаєме текст
            int num1, num2, result; //вызначаєме ціфры
            Console.WriteLine("\t\tДОДАВАНЯ ДВОХ ЧІСЕЛ\n");
            Console.Write("Ввидїть 1. чісло: ");
            str = Console.ReadLine();  
            num1 = Convert.ToInt32(str); /* КОНВЕРТАЦІЯ */
            //інтовӯй переміннуй num1 конвертиме значиння текстовойи прм str

            Console.Write("Ввидїть 2. чісло: ");
            str = Console.ReadLine();
            num2 = Convert.ToInt32(str); 
            result = num1 + num2; 
            Console.WriteLine("Cумма чісел: " + result);

            
        }
    }
}
