//Слюсаренко Вячеслав
//    3* Описать класс дробей - рациональных чисел, являющихся отношением двух целых чисел.
// Предусмотреть методы сложения, вычитания, умножения и деления дробей. Написать
// программу, демонстрирующую все разработанные элементы класса.Достаточно решить 2
//задачи.Все программы сделать в одном решении.
//** Добавить упрощение дробей.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    class Rational
    {
        // Возвращает наибольший общий делитель (Алгоритм Евклида)
        private static int getGreatestCommonDivisor(int a, int b)
        {
            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }
            return a;
        }
        private static int getLeastCommonMultiple(int a, int b)
        {
            return a * b / getGreatestCommonDivisor(a, b);
        }
    }

    



    //class Rational
    //{
    //    struct PointA
    //    {
    //        public double ca;
    //        public double za;
    //    }
    //    struct PointB
    //    {
    //        public double cb;
    //        public double zb;
    //    }
    //    public Rational Nok(double zb ,double  za)
    //    {

    //        Rational Nok = new Rational();
    //        Nok = zb * za;
    //        return Nok;
    //    }

    //    //public int Point (double A, double B)
    //    //{
    //    //    A = ca && za;

    //    //    return Point;
    //    //}
    //    static void Main()
    //    {


    //        Console.ReadLine();
    //    }
    //    public int Multiple(int a, int b)
    //    {

    //        return a * b / Nok(za, zb);
    //    }


    //}


}

