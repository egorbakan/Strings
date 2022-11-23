using System;

namespace Строки
{
    class Program
    {
        static void Main(string[] args)
        {
            /* string s1 = "Привет ";
             string s2 = "Мир";
             string s3 = string.Concat(s1, s2);

             Console.WriteLine(s3);*/

            // Метод Compare
           /* string st1 = "Привет";
             string st2 = "Мир!";

             int echo = string.Compare(st1, st2);
             if (echo < 0)
             {
                 Console.WriteLine("Строка st1 стоит после строки st2");
             }
             else if (echo > 0)
             {
                 Console.WriteLine("Строка st1 стоит перед строкой st2");
             }
             else
             {
                 Console.WriteLine("Строки st1 и st2 одинаковы");
             }
             */

            // Метод IndexOf

            /*string str1 = "Привет мир!";
            char search = 'в';
            int indexOfChar = str1.IndexOf(search); // поиск буквы "в"
            Console.WriteLine(indexOfChar);

            string substring = "м";
            int indexOfSubstring = str1.IndexOf(substring); // поиск буквы "м"
            Console.WriteLine(indexOfSubstring);
            */

          /*  // Метод Contains
            String str = "Привет";
            String substr1 = "в";
            String substr2 = "а";
            Console.WriteLine(str.Contains(substr1));  //проверка, есть ли в строке буква "в"
            Console.WriteLine(str.Contains(substr2));  //проверка, есть ли в строке буква "а"
          */

          /*  // Метод CompareOrdinal
            string s1 = "Привет";
            string s2 = "Привет";
            string s3 = "Мир";
            string s4 = "csharp";

            Console.WriteLine(string.CompareOrdinal(s1, s2));
            Console.WriteLine(string.CompareOrdinal(s1, s3));
            Console.WriteLine(string.CompareOrdinal(s3, s4));
          */

            /*
            // Метод Equals
            string s1 = "Привет";
            string s2 = "Привет";            
            Console.WriteLine(s1.Equals(s2));// Equals() возвращает значение верно/ложь
            */
        }
    }
}
