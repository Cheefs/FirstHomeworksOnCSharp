//        Слюсаренко Вячеслав
//2. Ввести вес и рост человека.Рассчитать и вывести индекс массы тела(ИМТ) по формуле
//    I=m/(h* h); где m-масса тела в килограммах, h - рост в метрах


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Дз_1._2___ИМТ
{
    class Program
    {
        static void Main(string[] args)
        {
            double h;
            double m;
            Console.WriteLine("Данное приложение производит расчет индекса массы тела");
            //Console.Write("Ваш рост, метров: "); //Это был первый вариант программы, но при запросе роста
            // если ставить 1(точка)72, а не запятую, программа немогла конертировать в дабл.
            // Решил запрашивать сантимеры роста, и внести строку перевода см в метры.
            Console.WriteLine("Ваш рост, см");
            string str = Console.ReadLine();
            h = Convert.ToDouble(str);
            h = h / 100;
            Console.Write("Ваш вес, кг: ");
            m = Convert.ToDouble(Console.ReadLine());

            double I = m / (h * h);
            Console.WriteLine("Ваш индекс массы тела равен: " + I);
            Console.ReadLine();



        }
    }
}
