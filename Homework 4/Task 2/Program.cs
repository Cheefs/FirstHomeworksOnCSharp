//Слюсаренко Вячеслав
//    2. а) Дописать класс для работы с одномерным массивом.Реализовать конструктор, создающий
//массив заданной размерности и заполняющий массив числами от начального значения с
//заданным шагом.Создать свойство Sum, которые возвращают сумму элементов массива, метод
//Inverse, меняющий знаки у всех элементов массива, Метод Multi, умножающий каждый элемент
//массива на определенное число, свойство MaxCount, возвращающее количество максимальных
//элементов.В Main продемонстрировать работу класса.
//б)* Добавить конструктор и методы, которые загружают данные из файла и записывают данные в
// файл.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Task_2
{
    class MyArray
    {
        int[] a;
       
        public MyArray(string filename /*int min, int max*/)
        {

            string[] str = File.ReadAllLines(filename);
            a = new int[str.Length];
            for (int i=0;i<str.Length;i++)
                a[i]=int.Parse(str[i]);
            


            //a = new int[N];
            //Random rnd = new Random();
            //for (int i = 0; i < N; i++)
            //    a[i] = rnd.Next(min, max);
        }
        public string Inverse
        {
            get
            {
                string str = "";
                for (int i = 0; i < a.Length; i++)
                    a[i] = -a[i];
                foreach (int el in a)
                    str += el + " ";
                return str;
            }
        }
        public string Multyply()
        {
            string mply = "";
            foreach (int el in a)
                mply = mply + el*5 + " ";
            return mply;
        }

        public int Summ()
        {
            int sum = a.Sum();
            return sum;
        }

        public int Max
        {
            get
            {
                int count = 0;
                int max = a[0];
                for (int i = 1; i < a.Length; i++)
                    if (a[i] > max) count++;
                return count;
            }
        }
        public override string ToString()
        {
            string s = "";
            foreach (int v in a)
                s = s + v + " ";
            return s;
        }
        public void Write(string filemane)
        {
            StreamWriter sw = null;
            sw = new StreamWriter(filemane);
            foreach (int el in a)
                sw.WriteLine(el);

                sw.Close();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {

            MyArray a = new MyArray("C:\\Users\\User\\Desktop\\Homework 4\\Task2.txt");
            a.Write("C:\\Users\\User\\Desktop\\Homework 4\\Task2.txt");
            Console.WriteLine("Элементы массива: "+a.ToString());
            Console.WriteLine("Количество максимальных элементов:" +a.Max);
            Console.WriteLine("Сумма элементов массива: " + a.Summ());
            Console.WriteLine("Произведение элементов массива на число 5: " + a.Multyply());
            Console.WriteLine("Инверсия элементов массива :" + a.Inverse);


            Console.ReadLine();
        }
    }
}
