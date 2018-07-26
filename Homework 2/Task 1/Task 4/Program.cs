//                  Слюсаренко Вячеслав
//    4. Реализовать метод проверки логина и пароля.На вход подается логин и пароль.На выходе
//      истина, если прошел авторизацию, и ложь, если не прошел(Логин:root, Password:GeekBrains).
//      Используя метод проверки логина и пароля, написать программу: пользователь вводит логин
//      и пароль, программа пропускает его дальше или не пропускает.С помощью цикла do while
//      ограничить ввод пароля тремя попытками.


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_4
{
    class Program
    {
  
        static void Main(string[] args)
        {
            
            string Login ;
            string Password;
            int count = 3;

            do
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Введите логин и пароль, попыток: " + count);
                Console.ResetColor();
                Console.Write("Введите логин: ");
                Login = Convert.ToString(Console.ReadLine());
                Console.Write("Введите пароль: ");
                Password = Convert.ToString(Console.ReadLine());
                
                count--;
                if (count == 0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Неверный логин или пароль, оставшыеся попытки: " + count);
                    break;
                }
              
            }
            while (Login !="root" || Password !="geekbrains");
            if (Login == "root" || Password == "GeekBrains")

            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Добро пожаловать!");

            }

            Console.ReadLine();

        }
    }
}
