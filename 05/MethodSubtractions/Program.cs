using System;

namespace MethodSubtractions
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
        /// Метод получающий две матрицы и производит вычитание
        /// </summary>
        /// <param name="Args">Параметры первой матрицы</param>
        /// <param name="Args1">Параметры второй матрицы</param>
        /// <returns></returns>
        public static int[,] SubtractionМatrix(int[,] Args, int[,] Args1)
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
        /// Метод выводящий в консоль полученную информацию
        /// </summary>
        /// <param name="Args"></param>
        public static void Print(int Args)
        {
            Console.WriteLine($"{Args,4}");
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
                    Console.Write($"{Args[i, j],4}");
                }
                Console.WriteLine();
            }
        }


        static void Main(string[] args)
        {
            int firstParameters = EnterMatrixParam();
            int secondParameters = EnterMatrixParam();

            int[,] firsMatrix = СompletionMassiv(firstParameters, secondParameters);
            int[,] secondMatrix = СompletionMassiv(firstParameters, secondParameters);
            int[,] resultSum = SubtractionМatrix(firsMatrix, secondMatrix);

            PrintMatrics(firsMatrix);
            Console.WriteLine("  -  ");
            PrintMatrics(secondMatrix);
            Console.WriteLine("  =  ");
            PrintMatrics(resultSum);
        }
    }
}
