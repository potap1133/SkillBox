using System;


namespace HomeWork_Methods_5
{
    class Program
    {
        /// <summary>
        /// Метод возвращающий введеное число
        /// </summary>
        /// <returns> Колличество строк первой матрицы </returns> 
        public static int DataEntryRowsFirst()
        {
            while (true)
            {
                try
                {
                    int matrixRowsFirst = 0;
                    Console.Write($" Введите колличество строк первой матрицы : ");
                    matrixRowsFirst = int.Parse(Console.ReadLine());

                    return matrixRowsFirst;
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
        /// Метод возвращающий введеное число
        /// </summary>
        /// <returns> Колличество столбцов первой матрицы </returns>
        public static int DataEntryColumnsFirst()
        {
            while (true)
            {
                try
                {
                    int matrixColumnsFirst = 0;

                    Console.Write($" Введите колличество столбцов первой матрицы : ");
                    matrixColumnsFirst = int.Parse(Console.ReadLine());

                    return matrixColumnsFirst;
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
        /// Метод возвращающий введеное число
        /// </summary>
        /// <returns> Колличество строк второй матрицы </returns>
        public static int DataEntryRowsSecond()
        {
            while (true)
            {
                try
                {
                    int matrixRowsSecond = 0;
                    Console.Write($" Введите колличество строк второй матрицы : ");
                    matrixRowsSecond = int.Parse(Console.ReadLine());

                    return matrixRowsSecond;
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
        /// Метод возвращающий введеное число
        /// </summary>
        /// <returns> Колличество столбцов второй матрицы </returns>
        public static int DataEntryColumnsSecond()
        {
            while (true)
            {
                try
                {
                    int matrixColumnsSecond = 0;

                    Console.Write($" Введите колличество столбцов второй матрицы : ");
                    matrixColumnsSecond = int.Parse(Console.ReadLine());

                    return matrixColumnsSecond;
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
        /// Метод возвращающий введеное число
        /// </summary>
        /// <returns> Множетель матрицы </returns>
        public static int EntryMultiplier()
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
        /// Метод умножения матрицы на число
        /// </summary>
        /// <param name="Args"> Параметры массива </param>
        /// <param name="Args1"> Множетель матрици </param>
        public static void ArrayOnNumber(int[,] Args ,int Args1)
        {
            Random r = new Random();

            int[,] result = new int[Args.Length, Args.Length];
            int[,] massiv = new int[Args.Length, Args.Length];

            for (int f = 0; f < Args.GetLength(0); f++)
            {
                for (int l = 0; l < Args.GetLength(1); l++)
                {
                    massiv[f, l] = r.Next(0, 10);
                    Console.Write($" {massiv[f, l],4} ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine($"  * {Args1}  ");
            Console.WriteLine();

            for (int i = 0; i < Args.GetLength(0); i++)
            {
                for (int a = 0; a < Args.GetLength(1); a++)
                {
                    result[i, a] = massiv[i, a] * Args1;
                    Console.Write($" {result[i, a],4} ");
                }
                Console.WriteLine();
            }
        }

        /// <summary>
        /// Метод сложения двух матриц
        /// </summary>
        /// <param name="ArgsFirst"> Параметры первого массива </param>
        /// <param name="ArgsSecond"> Параметры второго массива </param>
        public static void ArrayPlusArray(int[,] ArgsFirst, int[,] ArgsSecond)
        {
            int[,] result = new int[ArgsFirst.Length, ArgsSecond.Length];
            int[,] massivFirst = new int[ArgsFirst.GetLength(0), ArgsFirst.GetLength(1)];
            int[,] massivSecond = new int[ArgsSecond.GetLength(0), ArgsSecond.GetLength(1)];

            if (ArgsFirst.GetLength(0) == ArgsSecond.GetLength(0) & ArgsFirst.GetLength(1) == ArgsSecond.GetLength(1))
            {
                Random r = new Random();
                Random r1 = new Random();

                for (int a = 0; a < ArgsFirst.GetLength(0); a++)
                {
                    for (int s = 0; s < ArgsSecond.GetLength(1); s++)
                    {                       
                        Console.Write($" {massivFirst[a,s] = r.Next(0,5),4} ");
                    }
                    Console.WriteLine();
                }

                Console.WriteLine();
                Console.WriteLine("       +        ");
                Console.WriteLine();

                for (int d = 0; d < ArgsFirst.GetLength(0); d++)
                {
                    for (int f= 0; f < ArgsSecond.GetLength(1); f++)
                    {
                        Console.Write($" {massivSecond[d, f] = r1.Next(0, 5),4} ");
                    }
                    Console.WriteLine();
                }

                Console.WriteLine();
                Console.WriteLine("       =        ");
                Console.WriteLine();

                for (int i = 0; i < ArgsFirst.GetLength(0); i++)
                {
                    for (int j = 0; j < ArgsSecond.GetLength(1); j++)
                    {
                        result[i, j] = massivFirst[i, j] + massivSecond[i, j];
                        Console.Write($" {result[i,j],4} ");
                    }
                    Console.WriteLine();
                }
            }



        }

        /// <summary>
        /// Метод вычитания двух матриц
        /// </summary>
        /// <param name="ArgsFirst"> Параметры первого массива </param>
        /// <param name="ArgsSecond"> Параметры второго массива </param>
        public static void ArrayMinusArray(int[,] ArgsFirst, int[,] ArgsSecond)
        {
            int[,] result = new int[ArgsFirst.Length, ArgsSecond.Length];
            int[,] massivFirst = new int[ArgsFirst.GetLength(0), ArgsFirst.GetLength(1)];
            int[,] massivSecond = new int[ArgsSecond.GetLength(0), ArgsSecond.GetLength(1)];

            if (ArgsFirst.GetLength(0) == ArgsSecond.GetLength(0) & ArgsFirst.GetLength(1) == ArgsSecond.GetLength(1))
            {
                Random r = new Random();
                Random r1 = new Random();

                for (int a = 0; a < ArgsFirst.GetLength(0); a++)
                {
                    for (int s = 0; s < ArgsSecond.GetLength(1); s++)
                    {
                        Console.Write($" {massivFirst[a, s] = r.Next(0, 5),4} ");
                    }
                    Console.WriteLine();
                }

                Console.WriteLine();
                Console.WriteLine("       -        ");
                Console.WriteLine();

                for (int d = 0; d < ArgsFirst.GetLength(0); d++)
                {
                    for (int f = 0; f < ArgsSecond.GetLength(1); f++)
                    {
                        Console.Write($" {massivSecond[d, f] = r1.Next(0, 5),4} ");
                    }
                    Console.WriteLine();
                }

                Console.WriteLine();
                Console.WriteLine("       =        ");
                Console.WriteLine();

                for (int i = 0; i < ArgsFirst.GetLength(0); i++)
                {
                    for (int j = 0; j < ArgsSecond.GetLength(1); j++)
                    {
                        result[i, j] = massivFirst[i, j] - massivSecond[i, j];
                        Console.Write($" {result[i, j],4} ");
                    }
                    Console.WriteLine();
                }
            }



        }

        /// <summary>
        /// Метод умножения двух матриц
        /// </summary>
        /// <param name="ArgsFirst"> Параметры первого массива </param>
        /// <param name="ArgsSecond"> Параметры второго массива </param>
        public static void ArrayMultiplyArray(int[,] ArgsFirst, int[,] ArgsSecond)
        {
            int[,] result = new int[ArgsFirst.GetLength(0), ArgsSecond.GetLength(1)];
            int[,] massivFirst = new int[ArgsFirst.GetLength(0), ArgsFirst.GetLength(1)];
            int[,] massivSecond = new int[ArgsSecond.GetLength(0), ArgsSecond.GetLength(1)];

            if (ArgsFirst.GetLength(0) == ArgsSecond.GetLength(1))
            {
                Random r = new Random();
                Random r1 = new Random();

                for (int a = 0; a < ArgsFirst.GetLength(0); a++)
                {
                    for (int s = 0; s < ArgsFirst.GetLength(1); s++)
                    {
                        Console.Write($" {massivFirst[a, s] = r.Next(0, 5),4} ");
                    }
                    Console.WriteLine();
                }

                Console.WriteLine();
                Console.WriteLine("       -        ");
                Console.WriteLine();

                for (int d = 0; d < ArgsSecond.GetLength(0); d++)
                {
                    for (int f = 0; f < ArgsSecond.GetLength(1); f++)
                    {
                        Console.Write($" {massivSecond[d, f] = r1.Next(0, 5),4} ");
                    }
                    Console.WriteLine();
                }

                Console.WriteLine();
                Console.WriteLine("       =        ");
                Console.WriteLine();

                for (int i = 0; i < ArgsFirst.GetLength(0); i++)
                {
                    for (int j = 0; j < ArgsSecond.GetLength(1); j++)
                    {
                        for (int q = 0; q < ArgsFirst.GetLength(1); q++)
                        {
                            result[i, j] += massivFirst[i, q] * massivSecond[q, j];
                            
                        }
                        Console.Write($" {result[i, j],4} ");
                    }
                    Console.WriteLine();
                }
            }
            else
            {
                Console.Clear();
                Console.WriteLine($" Не корректный ввод данных ");
            }



        }

        static void Main(string[] args)
        {
            while (true)
            {
                try
                {
                    //int matrixRowsFirst = DataEntryRowsFirst();                   
                    //int matrixColumnsFirst = DataEntryColumnsFirst();
                    //int matrixRowsSecond = DataEntryRowsSecond();
                    //int matrixColumnsSecond = DataEntryColumnsSecond();

                    //ArrayPlusArray(new int[matrixRowsFirst, matrixColumnsFirst], new int[matrixRowsSecond, matrixColumnsSecond]);
                   

                    int matrixRowsFirst = DataEntryRowsFirst();
                    int matrixColumnsFirst = DataEntryColumnsFirst();
                    int matrixRowsSecond = DataEntryRowsSecond();
                    int matrixColumnsSecond = DataEntryColumnsSecond();

                    ArrayMultiplyArray(new int[matrixRowsFirst, matrixColumnsFirst], new int[matrixRowsSecond, matrixColumnsSecond]);


                    //int matrixRowsFirst = DataEntryRowsFirst();
                    //int matrixColumnsFirst = DataEntryColumnsFirst();
                    //int multiplier = DataEntryMultiplier();

                    //ArrayOnNumber(new int[matrixRowsFirst, matrixColumnsFirst], multiplier);

                    break;
                }
                catch (OverflowException)
                {
                    Console.WriteLine(" Некорректный ввод данных! Повторите ввод!");
                    Console.ReadKey();
                    Console.Clear();
                    continue;
                }
            }
        }
    }
}
