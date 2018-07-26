//                  Слюсаренко Вячеслав
//    1. а) Дописать структуру Complex, добавив метод вычитания комплексных чисел.
//       Продемонстрировать работу структуры;
//       б) Дописать класс Complex, добавив методы вычитания и произведения чисел.Проверить
//          работу класса;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_3
{
    #region OOP
    class Complex
    {

        double im;
        double re;
        public Complex()
        {
            im = 0;
            re = 0;
        }

        public Complex(double im, double re)
        {
            this.im = im;
            this.re = re;
        }

        public Complex Plus(Complex x2)
        {
            Complex x3 = new Complex();
            x3.im = x2.im + im;
            x3.re = x2.re + re;
            return x3;
        }
        public Complex Minus(Complex x3)
        {
            Complex x4 = new Complex();
            x4.im = x3.im - im;
            x4.re = x3.re - re;
            return x4;
        }
        public Complex Multiply(Complex x4)
        {
            Complex x5 = new Complex();
            x5.im = x4.im * im;
            x5.re = x4.re * re;
            return x5;
        }
        public double Im
        {
            get { return im; }
            set
            {
                if (value >= 0) im = value;
            }
        }
        public string ToStringMinus()
        {
            return re + "-" + im + "i";
        }
        public string ToStringPlus()
        {
            return re + "+" + im + "i";
        }
        public string ToStringMultiply()
        {
            return re + "*" + im + "i";
        }

        static void Main(string[] args)
        {
            Complex complex1 = new Complex(1.5, 2.3);
            Complex complex2 = new Complex(2, 2);
            Complex complex3 = new Complex(3, 3);
            Complex complex4 = new Complex(4, 4);
            complex2.im = 3;
            complex3.im = 4;
            complex4.im = 5;
            Complex result;

            result = complex1.Plus(complex2);
            result = complex1.Minus(complex3);
            result = complex1.Multiply(complex4);

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Результат: " + result.ToStringPlus());
            Console.WriteLine("Результат: " + result.ToStringMinus());
            Console.WriteLine("Результат: " + result.ToStringMultiply());
            Console.Title = "C# Homework lesson 3";
            Console.ResetColor();
            Console.ReadLine();
        }
    }
    #endregion

    #region Complex default
    //class Complex
    //{

    //    public double im;
    //    public double re;
    //    public Complex Plus(Complex x2)
    //    {
    //        Complex x3 = new Complex();
    //        x3.im = x2.im + this.im;
    //        x3.re = x2.re + this.re;
    //        return x3;
    //    }
    //    public Complex Minus(Complex x3)
    //    {
    //        Complex x4 = new Complex();
    //        x4.im = x3.im - im;
    //        x4.re = x3.re - re;
    //        return x4;
    //    }
    //    public Complex Multiply(Complex x4)
    //    {
    //        Complex x5 = new Complex();
    //        x5.im = x4.im * im;
    //        x5.re = x4.re * re;
    //        return x5;
    //    }
    //    public string ToStringMinus()
    //    {
    //        return re + "-" + im + "i";
    //    }
    //    public string ToStringPlus()
    //    {
    //        return re + "+" + im + "i";
    //    }
    //    public string ToStringMultiply()
    //    {
    //        return re + "*" + im + "i";
    //    }
    //}
    //class Program
    //{
    //    static void Main(string[] args)
    //    {

    //        Complex complex1 = new Complex();
    //        complex1.re = 1;
    //        complex1.im = 1;
    //        Complex complex2 = new Complex();
    //        complex2.re = 1;
    //        complex2.im = 1;
    //        Complex result = complex1.Plus(complex2);
    //       /* Console.WriteLine(result.ToStringPlus())*/;
    //        string msg = "Результат: ";

    //        Console.ForegroundColor = ConsoleColor.Yellow;
    //        Print(msg + result.ToStringPlus());
    //        Print(msg + result.ToStringMinus());
    //        Print(msg + result.ToStringMultiply());
    //        Console .ReadLine();
    //    }
    //    #region Print
    //    static void Print(string msg)
    //    {
    //        Console.WriteLine(msg);
    //    }
    //    #endregion

    //}
    #endregion

}

