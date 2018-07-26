//        Слюсаренко Вячеслав
//    7. a) Разработать рекурсивный метод, который выводит на экран числа от a до b(a<b);
//       б) * Разработать рекурсивный метод, который считает сумму чисел от a до b.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_7
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            int b;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Вывод на экран чисел от a до b, и подсчет их суммы");
            Console.ResetColor();
            Console.Write("Введите значение - a: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите значение - b: ");
            b = Convert.ToInt32(Console.ReadLine());
            int sum = 0;

            if (a < b)
            {
                sum = (b * (b + a) / 2);
            }

            Recurse(a, b);
     
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Beep();//Звуковой сигнал
            Console.WriteLine("\nСумма всех чисел в диапазоне " + "от " +a+" до "+ b +" равна "+ sum);
            Console.ReadLine();

        }
        static void Recurse(int a, int b)
        {
            Console.Write("{0,4} ", a);
            if (a < b) Recurse(a + 1, b);
            
        }
         
    }
 }

