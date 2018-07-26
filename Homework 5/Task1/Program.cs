//    Слюсаренко Вячеслав

//      1. Создать программу, которая будет проверять корректность ввода логина.Корректным
//          логином будет строка от 2-х до 10-ти символов, содержащая только буквы или цифры, и при
//          этом цифра не может быть первой.
//          а) без использования регулярных выражений;
//          б) ** с использованием регулярных выражений.


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Task1
{
    class Program
    {
        
        static void Main()
        {
        #region 1 а) без использования регулярных выражений;
            try
            {
                Console.Title = "C# Lesson 5 Task 1";
                Console.Write("Login: ");
                string login = (Console.ReadLine());

                if (login.Length > 2 & login.Length < 10 & !char.IsDigit(login[0]))
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("GOOD lOGIN ");
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("BAD LOGIN");
                }
                   
            }
            catch (FormatException )
            {
                Console.WriteLine("Error");
            }
            #endregion

        #region 2  б) ** с использованием регулярных выражений.
            //Console.Write("Login: ");

            //login = Console.ReadLine();
            ////var myReg = Regex.IsMatch(login, @"[^0-9]+[\wA-Za-z0-9]{1,9}");
            //var myReg = Regex.IsMatch(login, @"[^0-9][\w]{1,9}");
            //if (myReg == true)
            //{
            //    Console.WriteLine("GOOD lOGIN ");
            //}
            //else Console.WriteLine("BAD LOGIN");
            #endregion

            Console.ReadLine();
        }
    }
}
