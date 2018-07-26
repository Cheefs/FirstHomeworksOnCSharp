#region 1 Черновик
///Слюсаренко Вячеслав
//        2. *Модифицировать программу нахождения минимума функции так, чтобы можно было
//передавать функцию в виде делегата. Сделать меню с различными функциями и представьте
//пользователю выбор для какой функции и на каком отрезке находить минимум. Используйте
//массив делегатов    
//*/


//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.IO;

//namespace Task_2
//{
//    public delegate double Fun(double x);
//    class Program
//    {

//        public static double Function1(double x)
//        {

//            return x * x - 50 * x + 10;
//        }
//        public static double Function2(double x)
//        {
//            return x * x + 20 * x - 34;
//        }
//        public static double Function3(double x)
//        {
//            return x * x + 5 * x + 34;
//        }
//        public static void SaveFunc(string fileName, double a, double b, double h, Fun F)
//        {
//            FileStream fs = new FileStream(fileName, FileMode.Create, FileAccess.Write);
//            BinaryWriter bw = new BinaryWriter(fs);
//            double x = a;
//            while (x <= b)
//            {
//                bw.Write(F(x));
//                x += h;// x=x+h;
//            }
//            bw.Close();
//            fs.Close();
//        }
//        public static double Load(string fileName)
//        {
//            FileStream fs = new FileStream(fileName, FileMode.Open, FileAccess.Read);
//            BinaryReader bw = new BinaryReader(fs);
//            double min = double.MaxValue;
//            double d;
//            for (int i = 0; i < fs.Length / sizeof(double); i++)
//            {

//                d = bw.ReadDouble();
//                if (d < min) min = d;
//            }
//            bw.Close();
//            fs.Close();
//            return min;
//        }
//        static void Main()
//        {
//            Fun[] F = { Function1, Function2, Function3 };
//            Console.WriteLine("Выберите функцию: \n1-Функция 1 \n2-Функция 2\n3-Функция 3");
//            int i = int.Parse(Console.ReadLine());


//            SaveFunc("data.bin", -100, 100, 0.5, F[i - 1]);
//            Console.WriteLine(Load("data.bin"));
//            Console.ReadLine();
//        }
//    }
//}
#endregion

/*              Слюсаренко Вячеслав
        2. *Модифицировать программу нахождения минимума функции так, чтобы можно было
передавать функцию в виде делегата. Сделать меню с различными функциями и представьте
пользователю выбор для какой функции и на каком отрезке находить минимум. Используйте
массив делегатов    
*/


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Task_2
{
    public delegate double Fun(double x, double f0, double f1);
    class Program
    {
        public static double f1;
        public static double f0;

        public static double Function1(double x,double f0,double f1)
        {

            return x * x - f0 * x +f1;
        }
        public static double Function2(double x, double f0, double f1)
        {
            return x * x + f0 * x - f1;
        }
        public static double Function3(double x, double t0, double t1)
        {
            return f0*Math.Sin(x)+f1;
        }
        public static void SaveFunc(string fileName, double t0, double t1, double h, Fun F)
        {
            FileStream fs = new FileStream(fileName, FileMode.Create, FileAccess.Write);
            BinaryWriter bw = new BinaryWriter(fs);
            double x = f0;
            while (x <= f1)
            {
                bw.Write(F(x,f0,f1));
                x += h;// x=x+h;
            }
            bw.Close();
            fs.Close();
        }
        public static double Load(string fileName)
        {
            FileStream fs = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            BinaryReader bw = new BinaryReader(fs);
            double min = double.MaxValue;
            double d;
            for (int i = 0; i < fs.Length / sizeof(double); i++)
            {

                d = bw.ReadDouble();
                if (d < min) min = d;
            }
            bw.Close();
            fs.Close();
            return min;
        }
        static void Main()
        {
            Console.Title = "C# Lesson 6: Task2";
            try
            {
                Fun[] F = { Function1, Function2, Function3 };
                Console.WriteLine("Выберите функцию: \n1-Функция 1 \n2-Функция 2\n3-Функция 3");
                int i = int.Parse(Console.ReadLine());
                Console.WriteLine("ВВедите координаты отрезка функции");
                Console.Write("Координата f0 :");
                f0 = Convert.ToDouble(Console.ReadLine());
                Console.Write("Координата f1 :");
                f1 = Convert.ToDouble(Console.ReadLine());
                SaveFunc("data.bin", -f0,f1, 0.5, F[i - 1]);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Минимум функции в заданных координтах равен: " + Load("data.bin"));
                
            }
            catch (Exception ex)
            {
                Console.WriteLine("\nError",Console.ForegroundColor=ConsoleColor.Red);
                Console.WriteLine(ex);
            }
            Console.ReadLine();
        }
    }
}







