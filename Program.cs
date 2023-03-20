using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR15_2
{
    class Program
    {
        static void Main(string[] args)
        {//
            string line = Console.ReadLine();
            char[] chars = line.ToCharArray();
            char[] rusalf = { "а", "б", "в", "г", "д", "е", "ё", "ж", "з", "и", "й", "к", "л", "м", "н", "о", "п", "р", "с", "т", "у", "ф", "х", "ц", "ч", "ш", "щ", "ъ", "ы", "ь", "э", "ю", "я" };
        //    HashSet<char> rusAlphabet = new HashSet<char>();
        //    for (char c = 'а'; c <= 'я'; c++)
        //    {
        //        rusAlphabet.Add(c);
        //    }
        //    Console.WriteLine("Множество букв русского алфавита");
        //    Print_mnozh(rusAlphabet);
            
        //    Console.WriteLine("Введите строку из букв");
        //    string line = Console.ReadLine();
        //    HashSet<char> setLine = TranslateLineToSet(line);
        //    Console.WriteLine();
        //    Console.ReadKey();
        //}
        ///// <summary>
        ///// Перевод строки в множество
        ///// </summary>
        ///// <param name="word"></param>
        ///// <returns></returns>
        //private static HashSet<char> TranslateLineToSet(string word)
        //{
        //    HashSet<char> setWord = new HashSet<char>();
        //    foreach(char c in word)
        //    {
        //        setWord.Add(c);
        //    }
        //    return setWord;
        //}
        ///// <summary>
        ///// Вывод множества на экран
        ///// </summary>
        ///// <param name="res"></param>
        //private static void Print_mnozh(HashSet<char> res)
        //{
        //    foreach (char s in res)
        //        Console.Write(s);
        //    Console.WriteLine();
        //}
    }
}

