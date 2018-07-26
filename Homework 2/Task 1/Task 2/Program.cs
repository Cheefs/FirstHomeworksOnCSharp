//       Слюсаренко Вячеслав
//  2. Написать метод подсчета количества цифр числа.


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            int count =0;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Программа подсчета цифр числа");
            Console.ResetColor();
            Console.Write("Введите любое число: ");
            n = Convert.ToInt32(Console.ReadLine());

            while (n!=0)
            {
                n = n / 10;
                count = count + 1;
               
            }
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Количество цифр в данном числе равно: "+count);
            Console.ReadLine();



        }
    }
}
