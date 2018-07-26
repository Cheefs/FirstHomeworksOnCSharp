//                  Слюсаренко Вячеслав
//    2. а) С клавиатуры вводятся числа, пока не будет введен 0 (каждое число в новой строке).
//          Требуется подсчитать сумму всех нечетных положительных чисел.Сами числа и сумму
//          вывести на экран; Используя tryParse;
//       б) Добавить обработку исключительных ситуаций на то, что могут быть введены некорректные
//              данные.При возникновении ошибки вывести сообщение.
//             

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
            int x = 0;
            string s;
            int summ = 0;
            string num = "Числа: ";

            do
            {
                Console.Write("Введите число: ");
                s = Convert.ToString(Console.ReadLine());
                int.TryParse(s, out x);
                //x = Convert.ToInt32(x);
                num += x + " ";
                if (x % 2 != 0 & x > 0)
                {
                    summ += x;
                }

                try
                {
                    x = Convert.ToInt32(s);
                }
                catch (FormatException ex)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Ошибка");
                    Console.WriteLine(ex.Message);
                    
                }

            }
            while (x != 0);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(num);
            Console.WriteLine("Сумма введенных нечетных, положительных чисел: " + summ);
            Console.ReadLine();
        }
    }
}