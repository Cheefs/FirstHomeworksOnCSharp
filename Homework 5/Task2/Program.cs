//          Слюсаренко Вячеслав

//          2. Разработать методы для решения следующих задач.Дано сообщение:
//              а) Вывести только те слова сообщения, которые содержат не более чем n букв;
//              б) Удалить из сообщения все слова, которые заканчиваются на заданный символ;
//              в) Найти самое длинное слово сообщения;
//              г) Найти все самые длинные слова сообщения.
//                  Постараться​​разработать​​класс​​MyString.


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class MyString
    {
      public  string text = @"Обработка текстовой информации является одной из самых распространённых задач современного
 программирования";
       public  char[] div = {' '};
        public string CN;
        public string DSW;
        
        public string CutN()  //а) Вывести только те слова сообщения, которые содержат не более чем n букв;
        {
            foreach (var el in text.Split(div))
                if (el.Length <7)
                {
                            CN += el+ " ";
                }

            return CN;
        }
        public string DellSomeWords()//б) Удалить из сообщения все слова, которые заканчиваются на заданный символ;
        {
            foreach (var el in text.Split(div))
                if (!el.EndsWith ("й"))
                {
                   DSW += el + " ";

                }
            return DSW;
        }
        public string FindLongestWord()//в) Найти самое длинное слово сообщения;
        {
            string longestWord = "";
            foreach (var el in text.Split(div))
                if (el.Length>longestWord.Length)
                {
                    longestWord = el;

                }
            return longestWord;
        }
        public string FLWAll()// г) Найти все самые длинные слова сообщения.
        {
            var longestWord ="";
            string longestWords="";
            foreach (var el in text.Split(div))
                if (el.Length > longestWord.Length)
                {
                    longestWord = el;

                }
            foreach (var el in text.Split(div))
                if (el.Length== longestWord.Length)
                {
                    longestWords += el+" ";
                }
            return longestWords;
        }

        static void Main(string[] args)
        {
            MyString str = new MyString();
            Console.WriteLine(str.text);
            Console.WriteLine("\n"+str.CutN(),Console.ForegroundColor=ConsoleColor.Yellow);
            Console.WriteLine("\n"+str.DellSomeWords(),Console.ForegroundColor = ConsoleColor.Green);
            Console.WriteLine("\n" + str.FindLongestWord(), Console.ForegroundColor = ConsoleColor.Cyan);
            Console.WriteLine("\n" + str.FLWAll(), Console.ForegroundColor = ConsoleColor.Magenta);

            Console.ReadLine();
        }
    }
}
