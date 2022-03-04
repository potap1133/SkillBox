// See https://aka.ms/new-console-template for more information
using System;

namespace MathodStringRevers
{
    class Program
    {

        /// <summary>
        /// Метод для ввода текста
        /// </summary>
        /// <returns> Возвращает введёный текст </returns>
        public static string Text()
        {
            Console.Write($" Введите текст ");
            string text = Console.ReadLine();

            return text;
        }

        /// <summary>
        /// Метод для удаления из текста знаков припенания, скобок и т.д.
        /// </summary>
        /// <param name="Args"> Введёный текст </param>
        /// <returns> Текст без пробелов </returns>
        public static string[] CleaningText(string Args)
        {
            Args = Args.Replace(',', ' ');
            Args = Args.Replace('(', ' ');
            Args = Args.Replace(')', ' ');
            Args = Args.Replace('.', ' ');
            Args = Args.Replace('-', ' ');

            string[] minString = Args.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            return minString;
        }

        /// <summary>
        /// Метод перестановки слов в обратном порядке.
        /// </summary>
        /// <param name="Args"> Введенй текст </param>
        /// <returns> Введеный текст с размещением слов в обратном порядке </returns>
        public static string[] ReverseWords( string[] Args )
        {
            int j = 0;
            string[] result = new string[Args.Length];

            for (int i = Args.Length - 1; i >= 0; i--)
            {
                
                result[j++] = Args[i];
            }

            return result;
        }
                              
        /// <summary>
        /// Метод выводит массив слов
        /// </summary>
        /// <param name="Args"> Массив слов </param>
        public static void PrintWords(string[] Args)
        {
            int argsOne = Args.Length;

            for (int i = 0; i < argsOne; i++)
            {
                Console.Write($" {Args[i]}");
            }
        }

        static void Main(string[] Args)
        {
            //string initialText = Text();
            string[] words = CleaningText(Text());
            //string[] reversWords = ReverseWords(words);
            ReverseWords(words);
            Console.WriteLine();
            PrintWords(words);
            Console.WriteLine();
            Console.WriteLine();

        }
    }
}


