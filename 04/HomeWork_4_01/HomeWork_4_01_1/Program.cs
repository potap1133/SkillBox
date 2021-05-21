using System;

namespace HomeWork_4_01_1
{
    class Program
    {
        static void Main(string[] args)
        {
                                                                                                                        // Инициализация переменных
            var b = 1;
            var counter = 0;
            var valumeChanges = 0;
            var numberTrianglePaskal = 0;
            
            Console.Write("Введите число : ");                                                                          // Запрос на введение числа 
            numberTrianglePaskal = int.Parse(Console.ReadLine());                                                       // Считывание числа

            int[,] arrayTriangle = new int[numberTrianglePaskal + 5, numberTrianglePaskal + 5];                         // Инициализация массива 

            for (int i = 0; i <= numberTrianglePaskal; i++)                                                             // Цикл расчета элементов треугольника Паскаля
            {
                b = 10;
                counter = numberTrianglePaskal - (i * 4);

                for (int a = 0; a <= i; a++)
                {
                    b++;

                    if ((a == 0) | (a == i))
                    {
                        valumeChanges = 1;
                    }
                    else
                    {
                        valumeChanges = arrayTriangle[i - 1, a - 1] + arrayTriangle[i - 1, a ];
                        
                    }

                    Console.SetCursorPosition(counter + (8 * b) , i + 2);                                                   // Место положения курсора

                    Console.Write($"{arrayTriangle[i, a] = valumeChanges} ");                                               // Вывод элементов треугольника
                }
                
            }



            Console.ReadKey();

        }
    }
}
