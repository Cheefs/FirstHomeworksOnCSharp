//                  Слюсаренко Вячеслав
//           3. а) Написать программу, которая подсчитывает расстояние между точками с координатами x1,
//                  y1 и x2,y2 по формуле r = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2).Вывести результат
//                  используя спецификатор формата .2f(с двумя знаками после запятой); #region 3-a/
//              б) * Выполните предыдущее задание оформив вычисления расстояния между точками в виде
//                   метода; #region 3-б


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Дз_1._3
{
    class Program
    {

        #region 3-a
        ////static void main(string[] args)
        //{

        //    //double x1;
        //    //double y1;
        //    //double x2;
        //    //double y2;

        //    //Console.Write("Введите значение х1: ");
        //    //string str = Console.ReadLine();
        //    //x1 = Convert.ToDouble(str);
        //    //Console.Write("Введите значение у1: ");
        //    //y1 = Convert.ToDouble(Console.ReadLine());
        //    //Console.Write("введите значение х2: ");
        //    //x2 = Convert.ToDouble(Console.ReadLine());
        //    //Console.Write("введите значение у2: ");
        //    //y2 = Convert.ToDouble(Console.ReadLine());

        //    //double r = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
        //    //Console.WriteLine("Растояние между точками равно:"+"{0:F2}", r);

        //    //Console.ReadLine();
        //}
        #endregion

        #region 3-б
        static void Pause()
        {
            Console.WriteLine("Нажмите Enter для запуска программы");
            Console.ReadKey();
        }

        static void Main(string[] args)
        {
            Pause();


            double x1;
            double y1;
            double x2;
            double y2;

            Console.Write("Введите значение х1: ");
            string str = Console.ReadLine();
            x1 = Convert.ToDouble(str);
            Console.Write("Введите значение у1: ");
            y1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("введите значение х2: ");
            x2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("введите значение у2: ");
            y2 = Convert.ToDouble(Console.ReadLine());

            double r = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
            Console.WriteLine("Растояние между точками равно:" + "{0:F2}", r);

            Console.ReadLine();
        }
    }
    #endregion
}


