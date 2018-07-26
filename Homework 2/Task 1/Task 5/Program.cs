//            Слюсаренко Вячеслав
//      5. а) Написать программу, которая запрашивает массу и рост человека, вычисляет его индекс
//         массы и сообщает, нужно ли человеку похудеть, набрать вес или все в норме;
//         б) * Рассчитать, на сколько кг похудеть или сколько кг набрать для нормализации веса.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_5
{
    class Program
    {
        static void IMT (int IMT)
        {
            double h;
            double m;

            Console.Write("Ваш рост, см: ");
            string str = Console.ReadLine();
            h = Convert.ToDouble(str);
            h = h / 100;
            Console.Write("Ваш вес, кг: ");
            m = Convert.ToDouble(Console.ReadLine());

            double I = m / (h * h);

        }
        static void Main(string[] args)
        { 
            Console.WriteLine($"Индекс массы тела {I:F2} ");
             if (I< 18.5)
             {

               double m1 = (h*100) - 110;
                m =m1-m;
               
                Console.WriteLine($"{m:F2} кг, нужно набрать");

             }
            if (I > 24.9) 
            {
 
                double m1 = (h * 100) - 110;
                m = m - m1;

                Console.WriteLine($"{m:F2} кг, нужно сбросить");
            }

            else Console.WriteLine("Ваш вес в педелах нормы");

            Console.ReadLine();


        }
    }
}
