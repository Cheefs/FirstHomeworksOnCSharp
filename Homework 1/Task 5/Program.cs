//                  Слюсаренко Вячеслав
//    5. а) Написать программу, которая выводит на экран ваше имя, фамилию и город проживания.
//       б) * Сделать задание, только вывод организуйте в центре экрана
//       в) ** Сделать задание б с использованием собственных методов(например, Print(string ms, int
//               x, int y).

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Дз_1._5
{
    class Program
    {
        #region 5-а) Написать программу, которая выводит на экран ваше имя, фамилию и город проживания.
        //static void Main(string[] args)
        //{
        //    Console.WriteLine("Слюсаренко Вячеслав, Кривой Рог, Украина");
        //    Console.ReadLine();
        //}
        #endregion

        #region 5-б) * Сделать задание, только вывод организуйте в центре экрана
        //static void Main(string [] args)
        //{
        //    Console.WriteLine("                 Слюсаренко Вячеслав, Кривой Рог, Украина");
        //    Console.ReadLine();
        //}
        #endregion

        #region 5-в)** Сделать задание б с использованием собственных методов

        static void Print(string msg, int x, int y)
        {
            Console.SetCursorPosition(x, y);
            Console.WriteLine(msg);
        }
        static void Main()
        {
            Print("Слюсаренко Вячеслав, Кривой Рог, Украина", 12, 11);
            Console.ReadLine();
        }
        #endregion
    }
}
