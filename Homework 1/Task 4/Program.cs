//Слюсаренко Вячеслав
//       4. Написать программу обмена значениями двух переменных:
//          а) с использованием третьей переменной;
//б) * без использования третьей переменной.


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Дз_1._4
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 4-a
            int a = 10;
            int b = 5;
            int c = a;
            Console.WriteLine("Обмен переменных а: " + a + " Переменной б: " + b);
            a = b;
            b = c;
            Console.WriteLine("Значение а стало равно: " + a + " Значение б: " + b);
            Console.ReadLine();
            #endregion


            #region 4-б
            int a = 10;
            int b = 15;
            Console.WriteLine("Обмен переменных а: " + a + " Переменной б: " + b);
            //бинарная алгебра
            a = a ^ b;//a=00000100
                      //a=11 (00001011)
                      //b=15 (00001111)
                      //a^b=00000100
            b = b ^ a; //b=00001011
                       //b=15 (00001111)
                       //a=4 (00000100)
                       //b^a =00001011
            a = a ^ b;//a=00001111
                      //a=4  (00000100)
                      //b=11 (00001011)
                      //a^b=00001011


            //математический метод
            //a = a + b;//25
            //b = b - a;//5
            //b = -b;//10
            //a = a - b;//15


            Console.WriteLine("Значение а стало равным: " + a + " Значениие б стало равным: " + b);
            Console.ReadLine();
            #endregion

        }
    }
}
