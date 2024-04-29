// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет: 
// "Позиция по рядам выходит за пределы массива" или "Позиция по колонкам выходит за пределы массива"

// using System;

// //Тело класса будет написано студентом. Класс обязан иметь статический метод PrintResult()
// class UserInputToCompileForTest
// { 
// // Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

// // Поиск элемента по позициям
//     public static int FindElementByPosition(int[,] array, int x, int y)
//     {
//         //Напишите свое решение здесь
//       int element = 0;
//       for (int i = 0; i < array.GetLength(0); i++)
//       {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//           if( i == x - 1 && j == y - 1)
//           {
//             element = array[i, j];
//           }
//         }
//       }
//       return element;
//     }

// // Проверка позиций на вхождение в массив
//     public static bool ValidatePosition(int[,] array, int x, int y)
//     {
//         //Напишите свое решение здесь
//       for ( int i = 0; i < array. GetLength(0); i++)
//       {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//           if (x > array.GetLength(0))
//           {
//             Console.WriteLine("Позиция по рядам выходит за пределы массива");
//             return false;
//           }
//            else if (y > array.GetLength(1))
//           {
//             Console.WriteLine("Позиция по колонкам выходит за пределы массива");
//             return false;
//           }
//         }
//       }
//       return true;
// }

//     public static void PrintResult(int[,] array, int x, int y)
//     {
//         if (ValidatePosition(array, x, y) == true)
//         {
//             System.Console.WriteLine(FindElementByPosition(array, x, y));
//         }
//     }
// }

// //Не удаляйте и не меняйте класс Answer!
// class Answer
// {
//     public static void Main(string[] args)
//     {   
//         int[,] array;

//         int x, y;

//         if (args.Length >= 3)
//         {
//             // Предполагается, что строки разделены запятой и пробелом, а элементы внутри строк разделены пробелом
//             string[] rows = args[0].Split(',');

//             int rowCount = rows.Length;
//             int colCount = rows[0].Trim().Split(' ').Length;

//             array = new int[rowCount, colCount];

//             for (int i = 0; i < rowCount; i++)
//             {
//                 string[] rowElements = rows[i].Trim().Split(' ');

//                 for (int j = 0; j < colCount; j++)
//                 {
//                     if (int.TryParse(rowElements[j], out int result))
//                     {
//                         array[i, j] = result;
//                     }
//                     else
//                     {
//                         Console.WriteLine($"Error parsing element {rowElements[j]} to an integer.");
//                         return;
//                     }
//                 }
//             }

//             // Парсинг x и y из аргументов
//             if (int.TryParse(args[1], out x) && int.TryParse(args[2], out y))
//             {
//                 // Теперь у вас есть двумерный массив "array" и координаты x и y
//                 UserInputToCompileForTest.PrintResult(array, x, y);
//             }
//             else
//             {
//                 Console.WriteLine("Error parsing x or y to an integer.");
//             }
//         }
//         else
//         {
           
//             // Если аргументов на входе нет, используем примерный массив
//             array = new int[,]
//             {
//                 {1, 2, 3, 4},
//                 {5, 6, 7, 8},
//                 {9, 10, 11, 12}
//             };
//             x = 2;
//             y = 2;
            
//             UserInputToCompileForTest.PrintResult(array, x, y);

//         }                
//     }
// }

// Задайте двумерный массив. 
// Напишите программу, которая поменяет местами первую и последнюю строку массива.

// ﻿using System;

// //Тело класса будет написано студентом. Класс обязан иметь статический метод PrintResult()
// class UserInputToCompileForTest
// {
//     // Печать массива
//     public static void PrintArray(int[,] array)
//     {
//         for (int i = 0; i < array.GetLength(0); i++)
//         {
//             for (int j = 0; j < array.GetLength(1); j++)
//             {
//                 System.Console.Write($"{array[i, j]}\t");
//             }
//             System.Console.WriteLine();
//         }
//     }

//     // Обмен первой с последней строкой
//     public static int[,] SwapFirstLastRows(int[,] array)
//     {
//         for (int i = 0; i < array.GetLength(1); i++)
//         {
//             SwapItems(array, i);
//         }
//         return array;
//     }
//     // Обмен элементами массива
//     public static void SwapItems(int[,] array, int i)
//     {
//         int LastRow = array.GetLength(0) - 1;
//         int temp = array[0, i];
//         array[0, i] = array[LastRow, i];
//         array[LastRow, i] = temp;
//     }
//     public static void PrintResult(int[,] numbers)
//     {
//         PrintArray(SwapFirstLastRows(numbers));
//     }
// }

// //Не удаляйте и не меняйте класс Answer!
// class Answer
// {
//     public static void Main(string[] args)
//     {
//         int[,] numbers;

//         if (args.Length >= 1)
//         {
//             // Предполагается, что строки разделены запятой и пробелом, а элементы внутри строк разделены пробелом
//             string[] rows = args[0].Split(',');

//             int rowCount = rows.Length;
//             int colCount = rows[0].Trim().Split(' ').Length;

//             numbers = new int[rowCount, colCount];

//             for (int i = 0; i < rowCount; i++)
//             {
//                 string[] rowElements = rows[i].Trim().Split(' ');

//                 for (int j = 0; j < colCount; j++)
//                 {
//                     if (int.TryParse(rowElements[j], out int result))
//                     {
//                         numbers[i, j] = result;
//                     }
//                     else
//                     {
//                         Console.WriteLine($"Error parsing element {rowElements[j]} to an integer.");
//                         return;
//                     }
//                 }
//             }
//         }
//         else
//         {
//             // Если аргументов на входе нет, используем примерный массив
//             numbers = new int[,]
//             {
//                 {1, 2, 3, 4},
//                 {5, 6, 7, 8},
//                 {9, 10, 11, 12}
//             };
//         }
//         UserInputToCompileForTest.PrintResult(numbers);
//     }
// }


// Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.

using System;

//Тело класса будет написано студентом. Класс обязан иметь статический метод PrintResult()
class UserInputToCompileForTest
{
    /// Вычисление сумм по строкам (на выходе массив с суммами строк)
    public static int[] SumRows(int[,] array)
    {
      //Напишите свое решение здесь
        int[] Summa = new int[array.GetLength(0)];
        int sum = 0;
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
                {
                    sum += array[i, j];
                }
            Summa[i] = sum;
            sum = 0;
        }
        return Summa;
    }
    
    // Получение индекса минимального элемента в одномерном массиве
    public static int MinIndex(int[] array)
    {
       //Напишите свое решение здесь
        int min = array[0];
        int index = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < min)
            {
                min = array[i];
                index = i;
            }
        }
        return index;
    }
    public static void PrintResult(int[,] numbers)
    {   
       //Напишите свое решение здесь
       System.Console.WriteLine(MinIndex(SumRows(numbers)));
    }
}

//Не удаляйте и не меняйте класс Answer!
class Answer
{
    public static void Main(string[] args)
    {
        int[,] numbers;

        if (args.Length >= 1)
        {
            // Предполагается, что строки разделены запятой и пробелом, а элементы внутри строк разделены пробелом
            string[] rows = args[0].Split(',');

            int rowCount = rows.Length;
            int colCount = rows[0].Trim().Split(' ').Length;

            numbers = new int[rowCount, colCount];

            for (int i = 0; i < rowCount; i++)
            {
                string[] rowElements = rows[i].Trim().Split(' ');

                for (int j = 0; j < colCount; j++)
                {
                    if (int.TryParse(rowElements[j], out int result))
                    {
                        numbers[i, j] = result;
                    }
                    else
                    {
                        Console.WriteLine($"Error parsing element {rowElements[j]} to an integer.");
                        return;
                    }
                }
            }
        }
        else
        {
            // Если аргументов на входе нет, используем примерный массив
            
            numbers = new int[,] {
                {1, 2, 3},
                {1, 1, 0},
                {7, 8, 2},
                {9, 10, 11}
    };      
        }
        UserInputToCompileForTest.PrintResult(numbers);
    }
}