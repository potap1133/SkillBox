using System;

namespace MatrixOnMatrix
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
                    int number = int.Parse(Console.ReadLine());

                    return number;

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
        /// Метод умножения матрцы на матрицу
        /// </summary>
        /// <param name="Args">Аргумент задающий количество строк первой матрицы</param>
        /// <param name="Args1">Аргумент задающий количество столбцов второй матрицы</param>
        /// <returns></returns>
        public static int[,] МatrixМultiplicationNumber(int[,] Args, int[,] Args1)
        {
            int argsOne = Args.GetLength(0);
            int argsTwo = Args.GetLength(1);
            int argsThree = Args1.GetLength(0);
            int argsFour = Args1.GetLength(1);

            int[,] result = new int[argsOne, argsFour];

            for (int i = 0; i < argsOne; i++)
            {
                for (int j = 0; j < argsThree; j++)
                {
                    for (int k = 0; k < argsTwo; k++)
                    {
                        result[i, j] += Args[i, k] * Args1[k, j];
                    }
                }
            }
            return result;

        }

        /// <summary>
        /// Метод проверяющий обязательное условие выполнения программы
        /// </summary>
        /// <param name="Args">Аргумент задающий количество строк первой матрицы</param>
        /// <param name="Args1">Аргумент задающий количество столбцов второй матрицы</param>
        /// <returns></returns>
        public static bool Сhecking(int Args, int Args1)
        {
            if (Args1 == Args)
            {
                return true;
            }
            else
            {
                return false;
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
            while (true)
            {
                int firstParameters = EnterNumber();
                int secondParameters = EnterNumber();
                int thirdParameters = EnterNumber();
                int fourthParameters = EnterNumber();

                int[,] firstMatrix = СompletionMassiv(firstParameters, secondParameters);
                int[,] secondMatrix = СompletionMassiv(thirdParameters, fourthParameters);

                bool condition = Сhecking(secondParameters, thirdParameters);
                if (condition == false)
                {
                    Console.WriteLine($" Повторите ввод ");
                    Console.ReadKey();
                    Console.Clear();
                    continue;
                }

                int[,] resultМultiplication = МatrixМultiplicationNumber(firstMatrix, secondMatrix);
               

                Console.WriteLine();
                PrintMatrics(firstMatrix);
                Console.WriteLine("  *  ");
                PrintMatrics(secondMatrix);
                Console.WriteLine("  =  ");
                PrintMatrics(resultМultiplication);

                break;
            }

        }
    }
}
