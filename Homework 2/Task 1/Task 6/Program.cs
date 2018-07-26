//        Слюсаренко Вячеслав
//    6. * Написать программу подсчета количества “Хороших” чисел в диапазоне от 1 до 1 000 000 000.
//      Хорошим называется число, которое делится на сумму своих цифр.Реализовать подсчет
//      времени выполнения программы, используя структуру DateTime.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_6
{
    class Program
    {
            static bool IsGood(int n)
            {
                for (int i = 2; i <= n / 2; i++)
                    if (n % i == 0) return false;
                return true;
            }
            static void Main(string[] args)
            {
                DateTime start = DateTime.Now;
                int summ = 0;
                for (int i = 2; i < 1000000000; i++)
                    if (IsGood(i))
                    {
                        summ+=i;
                        Console.WriteLine(i);
                    }
                Console.WriteLine(summ);

                
                Console.WriteLine(DateTime.Now - start);
            Console.ReadLine();

            }
        }
}
