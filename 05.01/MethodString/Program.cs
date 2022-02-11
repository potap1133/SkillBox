using System;


namespace MethodString
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
                Console.WriteLine($" {Args[i]} ");
            }
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

        public static string SortWord(int[] Args, string[] Args1)
        {
            string result = null;

            for (int i = 0; i < Args.Length; i++)
            {
                if (Args[0] == Args1[i].Length)
                {
                    result = Args1[i];
                }
            }
            return result;
        }

       



        static void Main(string[] args)
        {
            string num1 = Text();
            string[] num2 = CleaningText(num1);
            int[] num3 = СonversionNumbers(num2);
            Array.Sort(num3);
            //Array.Reverse(num3);
            Console.WriteLine();
            string result = SortWord(num3, num2);
            Console.ReadKey();
            PrintWordsOn(result);
            //for (int i = 0; i < num2.Length; i++)
            //{
            //    PrintWordsOn(num2);
            //}



            //Console.Write($" Введите текст: ");
            //string num1 = Console.ReadLine();
            //num1 = num1.Replace(',', ' ');
            //num1 = num1.Replace('(', ' ');
            //num1 = num1.Replace(')', ' ');
            //num1 = num1.Replace('.', ' ');
            //string[] num4 = num1.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            //int[] num5 = new int[num4.Length];

            //for (int i = 0; i < num4.Length; i++)
            //{
            //    num5[i] = num4[i].Length;

            //}
            //Array.Sort(num5);
            //Array.Reverse(num5);

            //Console.WriteLine();
            //for (int j = 0; j < num5.Length; j++)
            //{

            //    //Console.WriteLine(num5[j]);

            //    if (num5[0] == num4[j].Length)
            //    {
            //        Console.WriteLine(num4[j]);
            //    }

            //}



        }
    }
}
