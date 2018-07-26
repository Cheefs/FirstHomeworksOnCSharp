//Слюсаренко Вячеслав
//    4. * а) Реализовать класс для работы с двумерным массивом.Реализовать конструктор,
// заполняющий массив случайными числами.Создать методы, которые возвращают сумму всех
//элементов массива, сумму всех элементов массива больше заданного, свойство, возвращающее
//минимальный элемент массива, свойство, возвращающее максимальный элемент массива,
//метод, возвращающий номер максимального элемента массива(через параметры, используя
//модификатор ref или out)
//** б) Добавить конструктор и методы, которые загружают данные из файла и записывают данные
// в файл.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Task4
{
    class MyArrayTwo
    {
        int[,] a;
        int[] Rows;
        //public  MyArrayTwo (string filename)
        //{
        //    string[,] str = File.ReadAllLines(filename);
        //    a = new int[str.Length];
        //    for (int i = 0; i < str.Length; i++)
        //        a[i] = int.Parse(str[i]);
        //}

        public MyArrayTwo(int n, int min, int max)
        {
            a = new int[n, n];
            Random rnd = new Random();
            for (int i = 0; i < n; i++)
                for (int j = 0; j < n; j++)
                    a[i, j] = rnd.Next(min, max);
        }
        public void Write(string filemane)
        {
            StreamWriter sw = null;
            sw = new StreamWriter(filemane);
            foreach (int el in a)
                sw.WriteLine(el);

            sw.Close();
        }
        public int Min
        {
            get
            {
                int min = a[0, 0];
                // Находим минимальный элемент
                // В двухмерном массиве для получения размерности нужно использовать
                // метод GetLength, а в скобках указывать измерение
                for (int i = 0; i < a.GetLength(0); i++)
                    for (int j = 0; j < a.GetLength(1); j++)
                        if (a[i, j] < min) min = a[i, j];
                return min;
            }
        }
        public int Max
        {
            get
            {
                int max = a[0, 0];
                for (int i = 0; i < a.GetLength(0); i++)
                    for (int j = 0; j < a.GetLength(1); j++)
                        if (a[i, j] > max) max = a[i, j];
                        
                return max;
            }
        }
        public int  MaxId ()
        {
            int s = 0;
            int count = 0;

                for (int i = 0; i < Rows.Length; i++)
                for (int j = 0; j < Rows.Length; j++)
                {
                s = a[i, j];
                    Rows[i] = s;
                    if (Rows[i] == Max)
                    {
                        for ( i = 0; i < Rows.Length; i++)
                            count++;
                        Console.WriteLine("jskdjs" + count);
                    }
                   
                   
                }
            return count;

        }
       
        // Метод - который возвращает массив в виде строки
        public override string  ToString()
        {
            string s = "";
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                    s += a[i, j] + " ";
                s += "\n"; // Переход на новую строчку
            }
            return s;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            
           
            MyArrayTwo a = new MyArrayTwo(2, 0, 10);
            a.Write("Task4.txt");
            Console.WriteLine(a.ToString());
            Console.WriteLine("\nМаксимальный элемент:" + a.Max);
            Console.WriteLine("Минимальный элемент:" + a.Min);
            Console.WriteLine("Refzxczxc "+ a.MaxId());
            Console.ReadLine();
        }
    }

}
