using System;

namespace MetodPluss
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
        /// Метод получающий две матрицы и складывает поочередно каждый элемент матрицы
        /// </summary>
        /// <param name="Args">Параметры первой матрицы</param>
        /// <param name="Args1">Параметры второй матрицы</param>
        /// <returns>Возвращает результат сложения матриц</returns>
        public static int[,] SumМatrix(int[,] Args, int[,] Args1)
        {
            int argsOne = Args.GetLength(0);
            int argsTwo = Args.GetLength(1);
            int argsThree = Args1.GetLength(0);
            int argsFour = Args1.GetLength(1);

            int[,] result = new int[argsOne, argsFour];

            for (int i = 0; i < argsOne; i++)
            {
                for (int j = 0; j < argsFour; j++)
                {
                    result[i, j] = Args[i, j] + Args1[i, j];
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
            int argsOne = Args.GetLength(0);
            int argsTwo = Args.GetLength(1);
            
            for (int i = 0; i < argsOne; i++)
            {
                for (int j = 0; j < argsTwo; j++)
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

            int[,] firsMatrix = СompletionMassiv( firstParameters,  secondParameters);
            int[,] secondMatrix = СompletionMassiv( firstParameters,  secondParameters);
            int[,] resultSum = SumМatrix(firsMatrix, secondMatrix);

            PrintMatrics(firsMatrix);
            Console.WriteLine("  +  ");
            PrintMatrics(secondMatrix);
            Console.WriteLine("  =  ");
            PrintMatrics(resultSum);

        }
    }
}
