using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Menu
{
    class Program
    {
        #region Task 1 
        static void Task1()
        {
            //    Слюсаренко Вячеслав
            //  1. Написать метод возвращающий минимальное из трех чисел.

            int a, b, c, min;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\nВведите 3 целых числа");
            Console.ResetColor();
            Console.Write("Введите первое число: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите второе число: ");
            b = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите третье число: ");
            c = Convert.ToInt32(Console.ReadLine());

            if (b > a && c > a)
            {
                min = a;

            }
            else if (a > b && c > b)
            {
                min = b;
            }

            else min = c;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("минимальное число: " + min);
            Console.ReadLine();

        }




        #endregion

        #region Task 2
        static void Task2()
        {
            //       Слюсаренко Вячеслав
            //  2. Написать метод подсчета количества цифр числа.
            int n;
            int count = 0;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\nПрограмма подсчета цифр числа");
            Console.ResetColor();
            Console.Write("Введите любое число: ");
            n = Convert.ToInt32(Console.ReadLine());

            while (n != 0)
            {
                n = n / 10;
                count = count + 1;

            }
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Количество цифр в данном числе равно: " + count);
            Console.ReadLine();



        }

        #endregion

        #region Task 3
        static void Task3()
        {
            //              Слюсаренко Вячеслав
            //      3. С клавиатуры вводятся числа, пока не будет введен 0. Подсчитать сумму всех нечетных
            //         положительных чисел.

            int a;
            int sum = 0;


            Console.Write("\nВведите число: ");
            a = Convert.ToInt32(Console.ReadLine());

            while (a != 0 && a > 0)
            {
                if (a % 2 != 0)
                {
                    sum += a;
                }
                Console.Write("Введите число: ");
                a = Convert.ToInt32(Console.ReadLine());
            }

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("Сумма всех введёных нечетных чисел равна :" + sum);
            Console.ReadLine();

        }




        #endregion

        #region Task 4
        static void Task4()
        {
            //                  Слюсаренко Вячеслав
            //    4. Реализовать метод проверки логина и пароля.На вход подается логин и пароль.На выходе
            //      истина, если прошел авторизацию, и ложь, если не прошел(Логин:root, Password:GeekBrains).
            //      Используя метод проверки логина и пароля, написать программу: пользователь вводит логин
            //      и пароль, программа пропускает его дальше или не пропускает.С помощью цикла do while
            //      ограничить ввод пароля тремя попытками.

            string Login;
            string Password;
            int count = 3;

            do
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("\nВведите логин и пароль, попыток: " + count);
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
            while (Login != "root" || Password != "geekbrains");
            if (Login == "root" || Password == "geekbrains")

            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Добро пожаловать!");

            }

            Console.ReadLine();
        }




        #endregion

        #region Task 5
        //            Слюсаренко Вячеслав
        //      5. а) Написать программу, которая запрашивает массу и рост человека, вычисляет его индекс
        //         массы и сообщает, нужно ли человеку похудеть, набрать вес или все в норме;
        //         б) * Рассчитать, на сколько кг похудеть или сколько кг набрать для нормализации веса.
        static void Task5()
        {
            double h;
            double m;

            Console.Write("\nВаш рост, см: ");
            string str = Console.ReadLine();
            h = Convert.ToDouble(str);
            h = h / 100;
            Console.Write("Ваш вес, кг: ");
            m = Convert.ToDouble(Console.ReadLine());

            double I = m / (h * h);

            Console.WriteLine($"Индекс массы тела {I:F2} ");
            if (I < 18.5)
            {

                double m1 = (h * 100) - 110;
                m = m1 - m;

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

        #endregion

        #region Task 6
        static void Task6()
        {
            //        Слюсаренко Вячеслав
            //    6. * Написать программу подсчета количества “Хороших” чисел в диапазоне от 1 до 1 000 000 000.
            //      Хорошим называется число, которое делится на сумму своих цифр.Реализовать подсчет
            //      времени выполнения программы, используя структуру DateTime.

            DateTime start = DateTime.Now;
            int summ = 0;
            for (int i = 2; i < 100000000; i++)
                if (IsGood(i))
                {
                    summ += i;
                    Console.WriteLine(i);
                }
            Console.WriteLine("\n"+summ);

            Console.WriteLine(DateTime.Now - start);
            Console.ReadLine();
        }

        static bool IsGood(int n)
        {
            for (int i = 2; i <= n / 2; i++)
                if (n % i == 0) return false;
            return true;
        }


        #endregion

        #region Task 7
        static void Task7()
        {
            //        Слюсаренко Вячеслав
            //    7. a) Разработать рекурсивный метод, который выводит на экран числа от a до b(a<b);
            //       б) * Разработать рекурсивный метод, который считает сумму чисел от a до b.

            try
            {
                int a;
                int b;
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("\nВывод на экран чисел от a до b, и подсчет их суммы");
                Console.ResetColor();
                Console.Write("Введите значение - a: ");
                a = Convert.ToInt32(Console.ReadLine());
                Console.Write("Введите значение - b: ");
                b = Convert.ToInt32(Console.ReadLine());
                int sum = 0;

                if (a < b)
                {
                    sum = (b * (b + a) / 2);
                }

                Recurse(a, b);
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Beep();//Звуковой сигнал
                Console.WriteLine("\nСумма всех чисел в диапазоне " + "от " + a + " до " + b + " равна " + sum);
                Console.ReadLine();
            }
            catch (FormatException ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Неверный формат данных");
                Console.WriteLine(ex.Message);
                Console.ReadLine();
                Console.ResetColor();

            }
        }
        static void Recurse(int a, int b)
        {
            Console.Write("{0,4} ", a);
            if (a < b) Recurse(a + 1, b);

        }

        #endregion

        #region Main
        static void Main(string[] args)
        {
            Console.Title = "С# Lesson 2 Homework";
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("1 - Task 1");
            Console.WriteLine("2 - Task 2");
            Console.WriteLine("3 - Task 3");
            Console.WriteLine("4 - Task 4");
            Console.WriteLine("5 - Task 5");
            Console.WriteLine("6 - Task 6");
            Console.WriteLine("7 - Task 7");
            Console.WriteLine("0 - Exit");
            ConsoleKeyInfo key = Console.ReadKey();
            switch (key.Key)
            {
                case ConsoleKey.D1:
                    Task1();
                    break;
                case ConsoleKey.D2:
                    Task2();
                    break;
                case ConsoleKey.D3:
                    Task3();
                    break;
                case ConsoleKey.D4:
                    Task4();
                    break;
                case ConsoleKey.D5:
                    Task5();
                    break;
                case ConsoleKey.D6:
                    Task6();
                    break;
                case ConsoleKey.D7:
                    Task7();
                    break;
                case ConsoleKey.D0:
                case ConsoleKey.Escape:
                    Console.WriteLine("Bye-bye");
                    return;
                default:
                    
                    break;
            }
        }

        #endregion
    }
}


