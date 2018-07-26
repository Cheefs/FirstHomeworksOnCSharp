/*              Слюсаренко Вячеслав
           1. Изменить программу вывода функции так, чтобы можно было передавать функции типа
              double(double,double). Продемонстрировать работу на функции с функцией a*x^2 и функцией
              a*sin(x).
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{       
    public delegate double Fun( double a, double x);
class Program
        {
            public static void Table(Fun F, double x, double b)
            {
                Console.WriteLine("----- X ----- Y -----");
                while (x <= b)
                {
                    Console.WriteLine("| {0,8:0.000} | {1,8:0.000} |", x, F(x,x));
                    x += 1;
                }
                Console.WriteLine("---------------------");
            }
        public static double MyFuncSin(double a, double x)
        {
            return a * Math.Sin (x);
        }
        public static double MyFuncSq(double a, double x)
        {
            return a * (x * x);
        }
        static void Main()
            {
            Console.Title = "C# Lesson 6: Task1";
            Console.WriteLine("Таблица функции a*Sin(x):");
            Table(new Fun (MyFuncSin),-2,6);
            Console.WriteLine("Таблица функции a*x^2:");
            Table(new Fun(MyFuncSq), -2, 6);
            Console.ReadKey();
            }
        }
    }