using System;

namespace ShortWord
{
    class Program
    {
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static string Text()
        {
            Console.Write($" Введите текст ");
            string text = Console.ReadLine();

            return text;
        }
        
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
         
        public static int[] СonversionNumbers(string[] Args)
        {
            int[] numbersWords = new int[Args.Length];

            for (int i = 0; i < Args.Length; i++)
            {
                numbersWords[i] = Args[i].Length;

            }

            return numbersWords;
        }
        
        public static string[] SortWord(int[] Args, string[] Args1)
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
            Array.Sort(numberWords);
            Array.Reverse(numberWords);
            string[] checkingWords = SortWord(numberWords, words);
            
            Console.WriteLine();

            PrintWords(checkingWords);

        }
    }
}
