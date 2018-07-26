//          Слюсаренко Вячеслав

//       1. Написать программу “Анкета”. Последовательно задаются вопросы(имя, фамилия, возраст,
//          рост, вес). В результате вся информация выводится в одну строчку.
//              а) используя склеивание;            
//              б) используя форматированный вывод; 
//              в) * используя вывод со знаком $.   
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ДЗ1._1_анкета
{
    class Program
    {
        static void Main(string[] args)
        {

            double h;
            double w;
            double age;

            Console.Write("Введите имя: ");
            string name = Console.ReadLine();
            Console.Write("Введите фамилию: ");
            string sname = Console.ReadLine();
            Console.Write("Ваш возвраст?: ");
            string str = Console.ReadLine();
            age = Convert.ToDouble(str);
            Console.Write("Ваш рост, см?: ");
            //string height = Console.ReadLine();

            h = Convert.ToDouble(Console.ReadLine());
            Console.Write("Ваш вес, кг?: ");
            w = Convert.ToDouble(Console.ReadLine());

            double h1 = h / 100;

            //console.writeline(format: "{0:f2}", arg0: (char)36 + name + (char)36 + sname + (char)36 + age + " лет " + (char)36+ h1 + " метров " + (char)36+ w + " кг. " + (char)36);
            Console.WriteLine($"{name} {sname} {age:F2} лет {h1:F2} метров {w:F2} кг");

            Console.ReadLine();
        }
    }
}
