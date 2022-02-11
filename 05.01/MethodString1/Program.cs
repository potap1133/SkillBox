using System;

namespace MethodString1
{
    class Program
    {
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
