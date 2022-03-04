using System;

namespace ShortWord
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
        /// Метод переводит массив из слов в массив чисел (колличечства букв в словах)
        /// </summary>
        /// <param name="Args"> Массив из слов </param>
        /// <returns> Массив чисел (колличечства букв всловах) </returns>
        public static int[] СonversionNumbers(string[] Args)
        {
            int[] numbersWords = new int[Args.Length];

            for (int i = 0; i < Args.Length; i++)
            {
                numbersWords[i] = Args[i].Length; 

            }

            return numbersWords;
        }

        /// <summary>
        /// Метод сортирует массив из чисел (колличечства букв в словах)
        /// </summary>
        /// <param name="Args"> Массив из чисел (колличечства букв в словах) </param>
        /// <returns> Отсортированный массив чисел </returns>
        public static int[] SortWords(int[] Args)
        {
            int temp;
            int numberArgs = Args.Length ;

            int[] result = new int[Args.Length];

            for (int i = 0; i < numberArgs; i++)
            {

                for (int j = 0; j < numberArgs; j++)
                {
                    if (Args[i] > Args[j])
                    {
                        temp = Args[i];
                        Args[i] = Args[j];
                        Args[j] = temp;
                    }
                }
            }
            return result;
        }

        /// <summary>
        /// Метод получает массив слов соответствующих определенному параметру
        /// </summary>
        /// <param name="Args"> Массив чисел (колличечства букв в словах) </param>
        /// <param name="Args1">Массив из слов</param>
        /// <returns> Массив слов соответствующих определенному параметру </returns>
        public static string[] SelectionWord(int[] Args, string[] Args1)
        {
            string[] resalt = new string[Args.Length];
            
            for (int i = 0; i < Args.Length; i++)
            {
                if (Args[0] == Args1[i].Length)
                {
                    resalt[i] = Args1[i];

                }
            }
            return resalt;
        }

        /// <summary>
        /// Метод выводит массив слов соответствующих определенному параметру
        /// </summary>
        /// <param name="Args"> Массив слов соответствующих определенному параметру </param>
        public static void PrintWords(string[] Args)
        {
            for (int i = 0; i < Args.Length; i++)
            {
                if (Args[i] is String)
                {
                    Console.Write($"{Args[i],2}\n\n");
                }
                
            }
        }
                
        static void Main(string[] args)
        {
            string initialText = Text();
            string[] words = CleaningText(initialText);
            int[] numberWords = СonversionNumbers(words);
            int[] srtingNumber = SortWords(numberWords);
            string[] checkingWords = SelectionWord(numberWords, words);
            
            Console.WriteLine();

            PrintWords(checkingWords);

        }
    }
}
