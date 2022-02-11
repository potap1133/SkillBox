using System;

namespace MethodString1
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
        /// Метод выводит массив слов в столбец
        /// </summary>
        /// <param name="Args"> Массив слов </param>
        public static void PrintWordsOn(string[] Args)
        {
            for (int i = 0; i < Args.GetLength(0); i++)
            {
                Console.WriteLine($"   {Args[i]} ");
            }
        }

        static void Main(string[] args)
        {
            string initialText = Text();
            string[] words = CleaningText(initialText);

            Console.ReadKey();
            Console.WriteLine();

            PrintWordsOn(words);
        }
    }
}
