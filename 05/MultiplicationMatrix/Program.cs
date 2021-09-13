using System;

namespace MultiplicationMatrix
{
    class Program
    {

        /// <summary>
        /// Метод для введния числа
        /// </summary>
        /// <returns>Возвращает число</returns>
        public static int EnterNumber()
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
        /// Метод умножения матрицы на число
        /// </summary>
        /// <param name="Args">Аргумент задающий параметры матрицы</param>
        /// <param name="Args1">Аргумент множетель матрицы</param>
        /// <returns>Возвращает результат умножения матрицы на число</returns>
        public static int[,] МultiplicationМatrix(int[,] Args, int Args1)
        {
            int[,] result = new int[Args.GetLength(0), Args.GetLength(1)];

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
            int firstParameters = EnterNumber();
            int secondParameters = EnterNumber();
            int matrixMultiplier = EnterNumber();

            int[,] Matrix = СompletionMassiv(firstParameters, secondParameters);
            int[,] resultМultiplication = МultiplicationМatrix(Matrix, matrixMultiplier);

            PrintMatrics(Matrix);
            Console.WriteLine("  *  ");
            Console.WriteLine($"{matrixMultiplier,4}");
            Console.WriteLine("  =  ");
            PrintMatrics(resultМultiplication);

        }
    }
}
