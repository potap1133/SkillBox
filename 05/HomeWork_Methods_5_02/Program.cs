using System;

namespace HomeWork_Methods_5_02
{
    class Program
    {
        
        /// <summary>
        /// Метод для введния числа
        /// </summary>
        /// <returns>Возвращает число</returns>
        public static int EnterMatrixParam()
        {
            while (true)
            {
                try
                {
                    Console.Write($" Введите число : ");
                    int matrixParam = int.Parse(Console.ReadLine());

                    
                    return matrixParam;

                }
                catch (FormatException)
                {
                    Console.WriteLine(" Некорректный ввод данных! ");
                    Console.ReadKey();
                    Console.Clear();
                    continue;
                }
            }
        }

        /// <summary>
        /// Метод для введния числа - Множетеля матрицы
        /// </summary>
        /// <returns>Возвращает число</returns>
        public static int EntryМultiplication()
        {
            while (true)
            {
                try
                {
                    int multiplier = 0;

                    Console.Write($" Введите множетель матрицы ");
                    multiplier = int.Parse(Console.ReadLine());

                    return multiplier;
                }
                catch (FormatException)
                {
                    Console.WriteLine(" Некорректный ввод данных! ");
                    Console.ReadKey();
                    Console.Clear();
                    continue;
                }
            }

        }

        /// <summary>
        /// Метод получающий два аргумента и заполняющий произвольными числами матрицу
        /// </summary>
        /// <param name="Args">Аргумент задающий количество строк матрицы</param>
        /// <param name="Args1">Аргумент задающий количество столбцов матрицы</param>
        /// <returns>Возвращает массив чисел</returns>
        public static int[,] СompletionMassiv(int Args, int Args1)
        {
            Random r = new Random();

            int[,] massivOne = new int[Args, Args1];

            for (int i = 0; i < Args; i++)
            {
                for (int j = 0; j < Args1; j++)
                {
                    massivOne[i, j] = r.Next(0, 10);
                }
            }
            return massivOne;
        }

        /// <summary>
        /// Метод выводящий в консоль матрицу
        /// </summary>
        /// <param name="Args"></param>
        public static void PrintMatrics(int[,] Args)
        {
            //int[,] mass = new int[Args.GetLength(0), Args.GetLength(1)];

            for (int i = 0; i < Args.GetLength(0); i++)
            {
                for (int j = 0; j < Args.GetLength(1); j++)
                {
                    Console.Write($"{Args[i,j],4}");
                }
                Console.WriteLine();
            }
        }

        /// <summary>
        /// Метод выводящий в консоль полученную информацию
        /// </summary>
        /// <param name="Args"></param>
        public static void Print(int Args)
        {
            Console.WriteLine($"{Args,4}");
        }

        /// <summary>
        /// Метод умножения матрицы на число
        /// </summary>
        /// <param name="Args">Аргумент задающий параметры матрицы</param>
        /// <param name="Args1">Аргумент множетель матрицы</param>
        /// <returns>Возвращает результат умножения матрицы на число</returns>
        public static int[,] МultiplicationМatrix(int[,] Args, int Args1)
        {
            int[,] result = new int[Args.GetLength(0),Args.GetLength(1)];

            for (int i = 0; i < Args.GetLength(0); i++)
            {
                for (int j = 0; j < Args.GetLength(1); j++)
                {
                    result[i, j] = Args[i, j] * Args1;
                }
            }
            return result;
        }

        /// <summary>
        /// Метод получающий две матрицы и складывает поочередно каждый элемент матрицы
        /// </summary>
        /// <param name="Args">Параметры первой матрицы</param>
        /// <param name="Args1">Параметры второй матрицы</param>
        /// <returns>Возвращает результат сложения матриц</returns>
        public static int[,] SummМatrix(int[,] Args, int[,] Args1)
        {
            int[,] result = new int[Args.GetLength(0), Args1.GetLength(1)];

            for (int i = 0; i < Args.GetLength(0); i++)
            {
                for (int j = 0; j < Args1.GetLength(1); j++)
                {
                    result[i, j] = Args[i, j] + Args1[i, j];
                }
            }
            return result;
        }

        /// <summary>
        /// Метод получающий две матрицы и производит вычитание
        /// </summary>
        /// <param name="Args">Параметры первой матрицы</param>
        /// <param name="Args1">Параметры второй матрицы</param>
        /// <returns></returns>
        public static int[,] MinusМatrix(int[,] Args, int[,] Args1)
        {
            int[,] result = new int[Args.GetLength(0), Args1.GetLength(1)];

            for (int i = 0; i < Args.GetLength(0); i++)
            {
                for (int j = 0; j < Args1.GetLength(1); j++)
                {
                    result[i, j] = Args[i, j] - Args1[i, j];
                }
            }
            return result;
        }

        /// <summary>
        /// Метод умножения матрцы на матрицу
        /// </summary>
        /// <param name="Args"></param>
        /// <param name="Args1"></param>
        /// <returns></returns>
        public static int[,] МatrixМultiplicationМatrix(int[,] Args, int[,] Args1)
        {
            int[,] result = new int[Args.GetLength(0), Args1.GetLength(1)];

            for (int i = 0; i < Args.GetLength(0); i++)
            {
                for (int j = 0; j < Args1.GetLength(1); j++)
                {
                    for (int k = 0; k < Args.GetLength(1); k++)
                    {
                        result[i, j] += Args[i, k] * Args1[k, j];
                    }
                }
            }
            return result;
        }

        static void Main(string[] args)
        {

            //int num = EnterMatrixParam();
            //int num1 = EnterMatrixParam();
            //int num3 = EntryМultiplication();

            //int [,] num2 = СompletionMassiv(num, num1);
            //int[,] num4 = МultiplicationМatrix(num2, num3);

            //Console.WriteLine();
            //PrintMatrics(num2);
            //Console.WriteLine();
            //Print(num3);
            //Console.WriteLine();
            //PrintMatrics(num4);

            //int num = EnterMatrixParam();
            //int num1 = EnterMatrixParam();
            //int num2 = EnterMatrixParam();
            //int num3 = EnterMatrixParam();

            //int[,] num4 = СompletionMassiv(num, num1);
            //int[,] num5 = СompletionMassiv(num2, num3);

            //int[,] num6 = SummМatrix(num4, num5);

            //Console.WriteLine();

            //PrintMatrics(num4);
            //Console.WriteLine();
            //PrintMatrics(num5);
            //Console.WriteLine();
            //PrintMatrics(num6);

            //int num = EnterMatrixParam();
            //int num1 = EnterMatrixParam();
            //int num2 = EnterMatrixParam();
            //int num3 = EnterMatrixParam();

            //int[,] num4 = СompletionMassiv(num, num1);
            //int[,] num5 = СompletionMassiv(num2, num3);

            //int[,] num6 = MinusМatrix(num4, num5);

            //Console.WriteLine();

            //PrintMatrics(num4);
            //Console.WriteLine();
            //PrintMatrics(num5);
            //Console.WriteLine();
            //PrintMatrics(num6);

            int num = EnterMatrixParam();
            int num1 = EnterMatrixParam();
            int num2 = EnterMatrixParam();
            int num3 = EnterMatrixParam();

            int[,] num4 = СompletionMassiv(num, num1);
            int[,] num5 = СompletionMassiv(num2, num3);

            int[,] num6 = МatrixМultiplicationМatrix(num4, num5);

            Console.WriteLine();

            PrintMatrics(num4);
            Console.WriteLine();
            PrintMatrics(num5);
            Console.WriteLine();
            PrintMatrics(num6);


        }
    }
}
