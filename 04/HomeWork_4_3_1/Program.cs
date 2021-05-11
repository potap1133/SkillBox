using System;

namespace HomeWork_4_3_1
{
    class Program
    {
        static void Main(string[] args)
        {

            int i = 0;                                                                                                      // Инициализация переменных
            int j = 0;                                                                                                      // Инициализация переменных
            int a = 0;                                                                                                      // Инициализация переменных
            int b = 0;                                                                                                      // Инициализация переменных

            int numberRowsArray = 0;                                                                                        // Инициализация переменных 
            int numberRowsArraySecond = 0;                                                                                  // Инициализация переменных 
            int numberColunsArray = 0;                                                                                      // Инициализация переменных
            int numberColunsArraySecond = 0;                                                                                // Инициализация переменных

            int matrixResultFirst = 0;                                                                                      // Инициализация переменных 
            int matrixResultSecond = 0;                                                                                     // Инициализация переменных             

            Random randomiz = new Random();                                                                                 // Генератор псевдо случайных чисел

            while (true)
            {

                while (true)                                                                                                // Цикл запроса и введения параметров массива                                                                                                           и определения исключений
                {
                    try
                    {
                        Console.Write($" Введите количество строк Первой Матрицы : ");                                      // Запрос ввода ьданнрых
                        numberRowsArray = int.Parse(Console.ReadLine());                                                    // Запрос ввода ьданнрых

                        if (numberRowsArray <= 0)
                        {
                            Console.WriteLine(" Некорректный ввод. Попрбуйте еще раз. ");                                   // Вывод сообщения об ошибке
                            Console.ReadKey();                                                                              // Ожидание нажатия любой клавиши
                            Console.Clear();                                                                                // Очистка экрана консоли
                            continue;                                                                                       // Возврат в начало цикла
                        }
                        break;                                                                                              // Прерывание цикла
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine(" Некорректный ввод. Попрбуйте еще раз. ");                                       // Вывод сообщения об ошибке
                        Console.ReadKey();                                                                                  // Ожидание нажатия любой клавиши
                        Console.Clear();                                                                                    // Очистка экрана консоли
                        continue;                                                                                           // Возврат в начало цикла
                    }

                }

                while (true)                                                                                                // Цикл запроса и введения параметров массива                                                                                                           и определения исключений      
                {
                    try
                    {
                        Console.Write($" Введите количество столбцов Первой Матрицы : ");                                   // Запрос ввода ьданнрых
                        numberColunsArray = int.Parse(Console.ReadLine());                                                  // Запрос ввода ьданнрых

                        if (numberRowsArray <= 0)
                        {
                            Console.WriteLine(" Некорректный ввод. Попрбуйте еще раз. ");                                   // Вывод сообщения об ошибке
                            Console.ReadKey();                                                                              // Ожидание нажатия любой клавиши
                            Console.Clear();                                                                                // Очистка экрана консоли
                            continue;                                                                                       // Возврат в начало цикла
                        }

                        break;                                                                                              // Прерывание цикла
                    }
                    catch (Exception)
                    {
                        Console.WriteLine(" Некорректный ввод. Попрбуйте еще раз. ");                                       // Вывод сообщения об ошибке
                        Console.ReadKey();                                                                                  // Ожидание нажатия любой клавиши
                        Console.Clear();                                                                                    // Очистка экрана консоли
                        continue;                                                                                           // Возврат в начало цикла
                    }

                }

                while (true)                                                                                                // Цикл запроса и введения параметров массива                                                                                                           и определения исключений
                {
                    try
                    {
                        Console.Write($" Введите количество строк Второй Матрицы : ");                                      // Запрос ввода ьданнрых
                        numberRowsArraySecond = int.Parse(Console.ReadLine());                                              // Запрос ввода ьданнрых

                        if (numberRowsArraySecond <= 0)
                        {
                            Console.WriteLine(" Некорректный ввод. Попрбуйте еще раз. ");                                   // Вывод сообщения об ошибке
                            Console.ReadKey();                                                                              // Ожидание нажатия любой клавиши
                            Console.Clear();                                                                                // Очистка экрана консоли
                            continue;                                                                                       // Возврат в начало цикла
                        }
                        break;                                                                                              // Прерывание цикла
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine(" Некорректный ввод. Попрбуйте еще раз. ");                                       // Вывод сообщения об ошибке
                        Console.ReadKey();                                                                                  // Ожидание нажатия любой клавиши
                        Console.Clear();                                                                                    // Очистка экрана консоли
                        continue;                                                                                           // Возврат в начало цикла
                    }

                }
                                
                while (true)                                                                                                // Цикл запроса и введения параметров массива                                                                                                           и определения исключений      
                {
                    try
                    {
                        Console.Write($" Введите количество столбцов Второй Матрицы : ");                                   // Запрос ввода ьданнрых
                        numberColunsArraySecond = int.Parse(Console.ReadLine());                                            // Запрос ввода ьданнрых

                        if (numberColunsArraySecond <= 0)
                        {
                            Console.WriteLine(" Некорректный ввод. Попрбуйте еще раз. ");                                   // Вывод сообщения об ошибке
                            Console.ReadKey();                                                                              // Ожидание нажатия любой клавиши
                            Console.Clear();                                                                                // Очистка экрана консоли
                            continue;                                                                                       // Возврат в начало цикла
                        }

                        break;                                                                                              // Прерывание цикла
                    }
                    catch (Exception)
                    {
                        Console.WriteLine(" Некорректный ввод. Попрбуйте еще раз. ");                                       // Вывод сообщения об ошибке
                        Console.ReadKey();                                                                                  // Ожидание нажатия любой клавиши
                        Console.Clear();                                                                                    // Очистка экрана консоли
                        continue;                                                                                           // Возврат в начало цикла
                    }

                }
               
                if (numberColunsArray != numberRowsArraySecond)                                                             // Условия для расчета произведения матриц
                {
                    Console.WriteLine(" Некорректный ввод. Попрбуйте ввести все значения еще раз. ");
                    Console.ReadKey();                                                                              // Ожидание нажатия любой клавиши
                    Console.Clear();
                    continue;
                }
                else
                {
                    break;
                }

            }

            int[,] arrayOfTheFirstMatrix = new int[numberRowsArray, numberColunsArray];                                     // Инициализация массива 
            int[,] arrayOfTheSecondMatrix = new int[numberRowsArraySecond, numberColunsArraySecond];                        // Инициализация массива             

            for (i = 0; i < numberRowsArray; i++)                                                                           // Цикл заполнения массива
            {
                Console.SetCursorPosition(1, 5 + (((numberColunsArray - numberRowsArray) / 2) + i));                        // Место положения курсора
                Console.Write("|");                                                                                         // Вывод прямого слеша
                Console.SetCursorPosition(2, 5 + (((numberColunsArray - numberRowsArray) / 2) + i));                        // Место положения курсора

                for (j = 0; j < numberColunsArray; j++)                                                                     // Цикл заполнения массива
                {   
                    arrayOfTheFirstMatrix[i, j] = randomiz.Next(0, 10);                                                     // Присвоение случайных чисел элементам массива
                    Console.Write($"{arrayOfTheFirstMatrix[i, j],4}");
                }

                Console.SetCursorPosition(3 + (numberColunsArray * 4),
                                          5 + (((numberColunsArray - numberRowsArray) / 2) + i));                           // Место положения курсора
                Console.Write("|");                                                                                         // Вывод прямого слеша
                Console.WriteLine();                                                                                        // Пустая строка
            }

            Console.SetCursorPosition(4 + (numberColunsArray * 4), 5 + (numberColunsArray / 2));                            // Место положения курсора
            Console.Write("*");                                                                                             // Вывод в консоль знака умножения

            for (int e = 0; e < numberRowsArraySecond; e++)                                                                 // Цикл заполнения массива
            {
                Console.SetCursorPosition(5 + (numberColunsArray * 4), 5 + e);                                              // Место положения курсора
                Console.Write("|");                                                                                         // Вывод прямого слеша
                Console.SetCursorPosition(6 + (numberColunsArray * 4), 5 + e);                                              // Место положения курсора

                for (a = 0; a < numberColunsArraySecond; a++)                                                               // Цикл заполнения массива
                {
                    arrayOfTheSecondMatrix[e, a] = randomiz.Next(0, 10);                                                    // Присвоение случайных чисел элементам массива
                    Console.Write($"{arrayOfTheSecondMatrix[e, a],4}");
                }

                Console.SetCursorPosition(7 + (numberColunsArray * 4) + (numberColunsArraySecond * 4), 5 + e);              // Место положения курсора
                Console.Write("|");                                                                                         // Вывод прямого слеша
                Console.WriteLine();                                                                                        // Пустая строка
            }

            Console.SetCursorPosition(8 + (numberColunsArray * 4) + (numberColunsArraySecond * 4),                          // Место положения курсора
                                      5 + (numberColunsArray / 2));
            Console.Write("=");                                                                                             // Вывод в консоль знака равенство

            for (int x = 0; x < numberRowsArray; x++)                                                                       // Произведение матриц
            {
                Console.SetCursorPosition(9 + (numberColunsArray * 4) + (numberColunsArraySecond * 4),                      // Место положения курсора
                                         ((numberColunsArray - numberRowsArray) / 2) + 5 + x);
                Console.Write("|");                                                                                         // Вывод прямого слеша
                Console.SetCursorPosition(10 + (numberColunsArray * 4) + (numberColunsArraySecond * 4),                     // Место положения курсора
                                         ((numberColunsArray - numberRowsArray) / 2) + 5 + x);

                for (int p = 0; p < numberColunsArraySecond; p++)
                {
                    matrixResultFirst = 0;                                                                                  // Обнуление результат

                    for (a = 0; a < numberColunsArray; a++)
                    {
                        matrixResultFirst += arrayOfTheFirstMatrix[x, a] * arrayOfTheSecondMatrix[a, p];                    // Вычисление результата
                    }

                    Console.Write($"{ matrixResultFirst,4}");                                                               // Вывод результата
                }

                Console.Write(" |");                                                                                        // Вывод прямого слеша
                Console.WriteLine("");                                                                                      // Пустая строка
            }

            Console.ReadKey();
            Console.SetCursorPosition(0, numberColunsArray * 100);
        }
    }   
}
