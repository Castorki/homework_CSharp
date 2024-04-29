// Задача 1: Задайте значения M и N. Напишите программу, которая выведет 
// все натуральные числа в промежутке от M до N. 
// Использовать рекурсию, не использовать циклы.

// void FromMtoN(int m, int n)
// {
//     if (m > n)
//     {
//         FromMtoN(m - 1, n);
//         System.Console.Write(m + " ");
//     }
//     else if (n > m)
//     {
//         FromMtoN(m, n - 1);
//         System.Console.Write(n + " ");
//     }
//     else System.Console.Write(m + " ");
// }
// FromMtoN(9, 2);

// Задача 2: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.

// int Ackermann(int m, int n)
// {
//     if (m == 0)
//     {
//         return n + 1;
//     }
//     else if (n == 0)
//     {
//         return Ackermann(m - 1, 1);
//     }
//     else
//     {
//         return Ackermann(m - 1, Ackermann(m, n - 1));
//     }
// }

// int result = Ackermann(3, 2);
// System.Console.WriteLine(result);

// Задача 3: Задайте произвольный массив. 
// Выведете его элементы, начиная с конца. Использовать рекурсию, не использовать циклы.


using System;

class Program
{
    static void PrintArray(int[] array, int i = 0)
    {
        if (i < array.Length)
        {
            PrintArray(array, i + 1);
            System.Console.Write(array[i] + " ");
        }
    }

    static void Main(string[] args)
    {
        int[] array = { 10, 3, 54, 194, 2, 0, 274 };
        PrintArray(array);
    }
}




