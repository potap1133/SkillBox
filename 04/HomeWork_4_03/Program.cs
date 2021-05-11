using System;

namespace HomeWork_4_3
{
    class Program
    {
        /// <summary>
        /// Программа вычисления произведения массивов.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {

            int i = 0;                                                                                                  // Инициализация переменных
            int j = 0;                                                                                                  // Инициализация переменных
            int a = 0;                                                                                                  // Инициализация переменных
            int b = 0;                                                                                                  // Инициализация переменных

            int numberRowsArray = 0;                                                                             // Инициализация переменных 
            int numberColunsArray = 0;                                                                           // Инициализация переменных
            
            int matrixResultFirst = 0;                                                                                  // Инициализация переменных 
            int matrixResultSecond = 0;                                                                                 // Инициализация переменных             

            Random randomiz = new Random();                                                                             // Генератор псевдо случайных чисел

            while (true)                                                                                                // Цикл запроса и введения параметров массива                                                                                                           и определения исключений
            {
                try
                {
                    Console.Write($" Введите количество строк Первой Матрицы : ");                                      // Запрос ввода ьданнрых
                    numberRowsArray = int.Parse(Console.ReadLine());                                             // Запрос ввода ьданнрых

                    if (numberRowsArray <= 0)
                    {
                        Console.WriteLine(" Некорректный ввод. Попрбуйте еще раз. ");
                        Console.ReadKey();
                        Console.Clear();
                        continue;
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
                    numberColunsArray = int.Parse(Console.ReadLine());                                           // Запрос ввода ьданнрых

                    if (numberRowsArray <= 0)
                    {
                        Console.WriteLine(" Некорректный ввод. Попрбуйте еще раз. ");
                        Console.ReadKey();
                        Console.Clear();
                        continue;
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
            
            int[,] arrayOfTheFirstMatrix = new int[numberRowsArray, numberColunsArray];                   // Инициализация массива 
            int[,] arrayOfTheSecondMatrix = new int[numberColunsArray, numberRowsArray];                  // Инициализация массива 
            int[,] productOfArrays = new int[numberRowsArray, numberRowsArray];                           // Инициализация массива 

            Console.WriteLine();                                                                                        // Пустая строка

            if (numberRowsArray == numberColunsArray)                                                     // Условие выбора решения
            {
                for (i = 0; i < numberRowsArray; i++)                                                            // Цикл заполнения массива
                {
                    Console.SetCursorPosition(1, 3 + i);                                                                // Место положения курсора
                    Console.Write("|");                                                                                 // Вывод прямого слеша
                    Console.SetCursorPosition(2, 3 + i);                                                                // Место положения курсора

                    for (j = 0; j < numberColunsArray; j++)                                                      // Цикл заполнения массива
                    {
                        arrayOfTheFirstMatrix[i, j] = randomiz.Next(0, 10);                                        // Присвоение случайных чисел элементам массива
                        Console.Write($"{arrayOfTheFirstMatrix[i, j],4}");
                    }
                    Console.Write("|");                                                                                 // Вывод прямого слеша
                    Console.WriteLine();                                                                                // Пустая строка
                }

                Console.SetCursorPosition(3 + (numberRowsArray * 4), 3 + (numberRowsArray / 2));          // Место положения курсора
                Console.Write("*");                                                                                     // Вывод в консоль знака умножения

                for (i = 0; i < numberRowsArray; i++)                                                            // Цикл заполнения массива
                {
                    Console.SetCursorPosition(4 + (numberRowsArray * 4), 3 + i);                                 // Место положения курсора
                    Console.Write("|");                                                                                 // Вывод прямого слеша
                    Console.SetCursorPosition(5 + (numberRowsArray * 4), 3 + i);                                 // Место положения курсора

                    for (a = 0; a < numberRowsArray; a++)                                                        // Цикл заполнения массива
                    {
                        arrayOfTheSecondMatrix[i, a] = randomiz.Next(0, 10);                                        // Присвоение случайных чисел элементам массива
                        Console.Write($"{arrayOfTheSecondMatrix[i, a],4}");
                    }
                    Console.Write("|");                                                                                 // Вывод прямого слеша
                    Console.WriteLine();                                                                                // Пустая строка
                }
                
                Console.SetCursorPosition(6 + ((numberRowsArray * 4) * 2), 3 + (numberRowsArray / 2));    // Место положения курсора
                Console.Write("=");                                                                                     // Вывод в консоль знака равенство

                for (i = 0; i < numberRowsArray; i++)                                                            // Цикл вычисления результата
                {
                    Console.SetCursorPosition(7 + ((numberRowsArray * 4) * 2), 3 + i);                           // Место положения курсора
                    Console.Write("|");                                                                                 // Вывод прямого слеша
                    Console.SetCursorPosition(8 + ((numberRowsArray * 4) * 2), 3 + i);                           // Место положения курсора

                    for (j = 0; j < numberColunsArray; j++)
                    {                                                                                                   // Вычисление результата и заполнение 
                        productOfArrays[i, j] = arrayOfTheSecondMatrix[i, j] * arrayOfTheFirstMatrix[i, j];             // элементов массива
                        Console.Write($"{productOfArrays[i, j],4}");                                                    // Вывод в консоль результата
                    }
                    Console.Write("|");                                                                                 // Вывод прямого слеша
                    Console.WriteLine();                                                                                // Пустая строка
                }

            }

            Console.WriteLine();                                                                                        // Пустая строка



            if (numberRowsArray < numberColunsArray)                                                      // Условие выбора решения
            {
                for (i = 0; i < numberRowsArray; i++)                                                            // Цикл заполнения массива
                {
                    Console.SetCursorPosition(1, 3 + (((numberColunsArray - numberRowsArray) / 2) + i));  // Место положения курсора
                    Console.Write("|");                                                                                 // Вывод прямого слеша
                    Console.SetCursorPosition(2, 3 + (((numberColunsArray - numberRowsArray) / 2) + i));  // Место положения курсора

                    for (j = 0; j < numberColunsArray; j++)                                                      // Цикл заполнения массива
                    {
                        arrayOfTheFirstMatrix[i, j] = randomiz.Next(0, 10);                                         // Присвоение случайных чисел элементам массива
                        Console.Write($"{arrayOfTheFirstMatrix[i, j],4}");
                    }
                    
                    Console.SetCursorPosition(3 + (numberColunsArray * 4),
                                              3 + (((numberColunsArray - numberRowsArray) / 2) + i));     // Место положения курсора
                    Console.Write("|");                                                                                 // Вывод прямого слеша
                    Console.WriteLine();                                                                                // Пустая строка
                }
                
                Console.SetCursorPosition(4 + (numberColunsArray * 4), 3 + (numberColunsArray / 2));      // Место положения курсора
                Console.Write("*");                                                                                     // Вывод в консоль знака умножения

                for (i = 0; i < numberColunsArray; i++)                                                          // Цикл заполнения массива
                {
                    Console.SetCursorPosition(5 + (numberColunsArray * 4), 3 + i);                               // Место положения курсора
                    Console.Write("|");                                                                                 // Вывод прямого слеша
                    Console.SetCursorPosition(6 + (numberColunsArray * 4), 3 + i);                               // Место положения курсора

                    for (a = 0; a < numberRowsArray; a++)                                                        // Цикл заполнения массива
                    {
                        arrayOfTheSecondMatrix[i, a] = randomiz.Next(0, 10);                                        // Присвоение случайных чисел элементам массива
                        Console.Write($"{arrayOfTheSecondMatrix[i, a],4}");
                    }
                    
                    Console.SetCursorPosition(7 + (numberColunsArray * 4) + (numberRowsArray * 4), 3 + i);// Место положения курсора
                    Console.Write("|");                                                                                 // Вывод прямого слеша
                    Console.WriteLine();                                                                                // Пустая строка
                }
                
                Console.SetCursorPosition(8 + (numberColunsArray * 4) + (numberRowsArray * 4),           // Место положения курсора
                                          3 + (numberColunsArray / 2));
                Console.Write("=");                                                                                     // Вывод в консоль знака равенство
                
                for (int x = 0; x < numberRowsArray; x++)
                {
                    Console.SetCursorPosition(9 + (numberColunsArray * 4) + (numberRowsArray * 4),       // Место положения курсора
                                             ((numberColunsArray - numberRowsArray) / 2) + 3 + x);
                    Console.Write("|");                                                                                 // Вывод прямого слеша
                    Console.SetCursorPosition(10 + (numberColunsArray * 4) + (numberRowsArray * 4),       // Место положения курсора
                                             ((numberColunsArray - numberRowsArray) / 2) + 3 + x);

                    for (int p = 0; p < numberRowsArray; p++)
                    {
                        matrixResultFirst = 0;

                        for (a = 0; a < numberColunsArray; a++)
                        {
                            matrixResultFirst += arrayOfTheFirstMatrix[x, a] * arrayOfTheSecondMatrix[a, p];            // Вычисление результата
                        }
                        
                        Console.Write($"{ matrixResultFirst,4}");
                    }
                
                    Console.Write(" |");                                                                                // Вывод прямого слеша
                    Console.WriteLine("");                                                                              // Пустая строка
                }

                Console.ReadKey();
                Console.SetCursorPosition( 0 , numberColunsArray * 100);
             }



            if (numberRowsArray > numberColunsArray)                                                      // Условие выбора решения
            {
                for (i = 0; i < numberRowsArray; i++)                                                            // Цикл заполнения массива
                {
                    Console.SetCursorPosition(1, 3 + i);                                                                // Место положения курсора
                    Console.Write("|");                                                                                 // Вывод прямого слеша
                    Console.SetCursorPosition(2, 3 + i);                                                                // Место положения курсора

                    for (a = 0; a < numberColunsArray; a++)                                                      // Цикл заполнения массива
                    {
                        arrayOfTheSecondMatrix[a, i] = randomiz.Next(0, 10);                                        // Присвоение случайных чисел элементам массива
                        Console.Write($"{arrayOfTheSecondMatrix[a, i],4}");
                    }
                    Console.Write("|");                                                                                 // Вывод прямого слеша
                    Console.WriteLine();                                                                                // Пустая строка
                }

                Console.SetCursorPosition(3 + (numberColunsArray * 4), 3 + (numberRowsArray / 2));        // Место положения курсора
                Console.Write("*");                                                                                     // Вывод в консоль знака умножения


                for (i = 0; i < numberColunsArray; i++)                                                          // Цикл заполнения массива
                {
                    Console.SetCursorPosition(4 + (numberColunsArray * 4),                                       // Место положения курсора
                                              3 + (((numberRowsArray - numberColunsArray) / 2) + i));
                    Console.Write("|");                                                                                 // Вывод прямого слеша
                    Console.SetCursorPosition(5 + (numberColunsArray * 4),                                       // Место положения курсора
                                              3 + (((numberRowsArray - numberColunsArray) / 2) + i));

                    for (j = 0; j < numberRowsArray; j++)                                                        // Цикл заполнения массива
                    {
                        arrayOfTheFirstMatrix[j, i] = randomiz.Next(0, 10);                                         // Присвоение случайных чисел элементам массива
                        Console.Write($"{arrayOfTheFirstMatrix[j, i],4}");
                    }
                    
                    Console.SetCursorPosition(6 + ((numberRowsArray * 4) + (numberColunsArray * 4)),      // Место положения курсора
                                              3 + (((numberRowsArray - numberColunsArray) / 2) + i));
                    Console.Write("|");                                                                                 // Вывод прямого слеша
                    Console.WriteLine();                                                                                // Пустая строка
                }

                Console.SetCursorPosition(7 + (numberColunsArray * 4) + (numberRowsArray * 4),           // Место положения курсора
                                          3 + (numberColunsArray / 2));
                Console.Write("=");                                                                                     // Вывод в консоль знака равенство

                for (int x = 0; x < numberRowsArray; x++)
                {
                    Console.SetCursorPosition(8 + (numberColunsArray * 4) + (numberRowsArray * 4),
                                              3 + x);
                    Console.Write("|");                                                                                 // Вывод прямого слеша
                    Console.SetCursorPosition(9 + (numberColunsArray * 4) + (numberRowsArray * 4),
                                              3 + x);

                    for (int p = 0; p < numberRowsArray; p++)
                    {
                        matrixResultFirst = 0;

                        for (a = 0; a < numberColunsArray; a++)
                        {
                            matrixResultFirst += arrayOfTheSecondMatrix[a, x] * arrayOfTheFirstMatrix[p, a];            // Вычисление результата
                        }
                        Console.Write($"{matrixResultFirst,4}");                     
                    }
                    
                    Console.Write("|");                                                                                // Вывод прямого слеша
                }
                Console.ReadKey();
            }
        }
    }
}
