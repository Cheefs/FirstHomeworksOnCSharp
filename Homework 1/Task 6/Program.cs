//              Слюсаренко Вячеслав
//    6. * Создать класс с методами, которые могут пригодиться в вашей учебе(Print, Pause).

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Дз_1._6
{
    class Program
    {
        static void Print(string msg, ConsoleColor colour, int x, int y)
        {
            Console.SetCursorPosition(x, y);
            Console.ForegroundColor = colour;
            Console.WriteLine(msg);
        }
        //static void Main(string[] args)
        //{
        //    int pasword=1234;
        //    Console.Write("Enter PASWORD to run this program");
        //    Console.ReadLine();
        //    if (pasword==1234)
        //    {
        //        Console.WriteLine("Welcom!Press Enter to Run Program");
        //    }
        //    else {
        //        Console.WriteLine("ERR");
        //       }

        //}
        static void Main()
        {

            Console.Write("Что вас интеесует ? расписание или учебный курс: ");
            string choise = Console.ReadLine();



            if (choise == "расписание")
            {
                Print("пн 15, чт 18,  22, чт 25, пн 29,чт  1, пн 5 , чт 8", ConsoleColor.Yellow, 11, 11);
            }
            else if (choise == "учебный курс")
            {
                Print(" С# Уровень 1\n Алгоритмы и структуры данных\n С# Уровень 2\n С# Уровень 3\n html/CSS\n C# ASP.NET MVS 6\n Стажировка", ConsoleColor.Yellow, 0, 5);
            }

            Console.ReadLine();

        }


    }
}
