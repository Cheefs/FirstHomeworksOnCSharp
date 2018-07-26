//              Слюсаренко Вячеслав
//      3. С клавиатуры вводятся числа, пока не будет введен 0. Подсчитать сумму всех нечетных
//         положительных чисел.


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            int sum = 0;


            Console.Write("Введите число: ");
            a = Convert.ToInt32(Console.ReadLine());

            while (a != 0 && a>0) 
            {
                if (a%2!=0)
                {
                    sum += a;
                }
                Console.Write("Введите число: ");
                a = Convert.ToInt32(Console.ReadLine());
            }

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("Сумма всех введёных нечетных чисел равна :"+sum);
            Console.ReadLine();

        }



    }

}

