//              Слюсаренко Вячеслав
//      3. Решить задачу с логинами из предыдущего урока, только логины и пароли считать из файла в
//          массив.


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Task_2
{
    class LoginPass
    {
        static void Main()
        {
            int count = 3;
            int[] a;
            string ULogin;
            string UPassword;
            string TrueLogin="";
            string TruePassword;
            StreamReader sr = null;
          sr =new StreamReader("C:\\Users\\User\\Desktop\\Homework 4\\Task3.txt");
            string[] LoginPass = new string[10];
            a = new int[LoginPass.Length];
            for (int i = 0; i < LoginPass.Length; i++)
                LoginPass[i] =sr.ReadLine();
            TrueLogin = LoginPass[0];
            TruePassword = LoginPass[1];

            do
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("\nВведите логин и пароль, попыток: " + count);
                Console.ResetColor();
                Console.Write("Введите логин: ");
                ULogin = Convert.ToString(Console.ReadLine());
                Console.Write("Введите пароль: ");
                UPassword = Convert.ToString(Console.ReadLine());

                count--;
                if (count == 0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Неверный логин или пароль, оставшыеся попытки: " + count);
                    break;
                }
                if (ULogin == TrueLogin & UPassword == TruePassword)

                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Добро пожаловать!");
                   
                }

            }
            while (ULogin!= TrueLogin || UPassword != TruePassword);
           
            Console.ReadLine();
        }
    }
}




