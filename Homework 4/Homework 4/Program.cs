//1. Дан целочисленный массив из 20 элементов.Элементы массива могут принимать целые
//значения от –10 000 до 10 000 включительно.Написать программу, позволяющую найти и
//вывести количество пар элементов массива, в которых хотя бы одно число делится на 3. В
//данной задаче под парой подразумевается два подряд идущих элемента массива.Например,
//для массива из пяти элементов: 6; 2; 9; –3; 6 – ответ: 4.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Homework_4
{
    class Program
    {
        static void Main()
        {
            int N = 20;
            int[] a;
            int count = 0;
            Console.Title = "C# Homework 4 -Task 1";
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Элементы массива: ");
            Console.ResetColor();

            Random rnd = new Random();
            a = new int[N];
            for (int i = 0; i < N; i++)
            {
                a[i] = rnd.Next(-10000, 10000);
            }
            for (int i=0; i<a.Length ;i++)
            {
                if (i<i+1 & a[i]%3==0)
                {
                    count++;
                }

                int k = a[i]; // вспомогательная переменная для хранения элемента массива
                
                Console.WriteLine( k);
            }
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Количество пар элементов в массиве: "+count);
            Console.ReadLine();
        }

    }
}

