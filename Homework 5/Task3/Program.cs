//          Слюсаренко Вячеслав

//      3. * Для двух строк написать метод, определяющий, является ли одна строка перестановкой
//          другой.Регистр можно не учитывать.
//          а) с использованием методов C#
//          б) * разработав собственный алгоритм
//              Например:
//              badc являются перестановкой abcd


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Перестановка";
            //char[] Abc = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
            //string s1 = "abcd"; ////Проверочный вариант, на работоспособность
            //string s2 = "dcba";
            string str = "";
            Console.WriteLine("Работа по поверке перестановки строк" , Console.ForegroundColor = ConsoleColor.Yellow);
            Console.ResetColor();
            Console.Write("Введите первую строку: ");
          string  s1 = Console.ReadLine();
            Console.Write("Введите вторую стоку: ");
          string s2 = Console.ReadLine();



            char[] s1Parts = new char[s1.Length];
            s1Parts = s1.ToCharArray();
            char[] s2Parts = new char[s2.Length];
            s2Parts = s2.ToCharArray();
            for (int el = 0; el < s1.Length; el++)
                for (int el2 = 0; el2 < s2.Length; el2++)
                    //foreach (var el in s1)
                    //    foreach (var el2 in s2)
                    if (s1.Length == s2.Length & s1Parts[el] == s2Parts[el2])
                    {
                        str += s1Parts[el];
                    }
            if (str == s1 || str == s2)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Cравнение :" + s1 + " и : " + s2 + " \nРеализуем перестановку во втором элементе");
                Console.WriteLine("Значение : " + s2 + " \nПосле перестановки: " + str);
                Console.WriteLine("Строки являются перестановкой");
                Console.ReadLine();
            }
            else
                Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Значение : "+ s2 + " \n Не является перестановкой элемента: " + s1);
            Console.ReadLine();
        }

    }
}
