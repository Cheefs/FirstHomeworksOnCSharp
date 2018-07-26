    //    Слюсаренко Вячеслав
    //  1. Написать метод возвращающий минимальное из трех чисел.



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c, min;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Введите 3 целых числа");
            Console.ResetColor();
            Console.Write("Введите первое число: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите второе число: ");
            b = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите третье число: ");
            c = Convert.ToInt32(Console.ReadLine());

            if (b > a && c > a )
            {
                min = a;

            }
            else if (a > b && c > b )
            {
                min = b;
            }

            else min = c;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("минимальное число: " + min);
           Console.ReadLine();

        }
    }
}
