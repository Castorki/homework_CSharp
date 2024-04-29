// Задача 1: Задайте двумерный массив символов (тип char [,]).
//  Создать строку из символов этого массива.

// using System.Runtime.InteropServices;

// string CharArrayToString(char[,] charArray)
// {
//     string result = string.Empty;
//     for (int i = 0; i < charArray.GetLength(0); i++)
//     {
//         for (int j = 0; j < charArray.GetLength(1); j++)
//         {
//             result = result + charArray[i, j];
//         }
//     }
//     return result;
// }


// //При запуске программы консоль зависает. 
// // Нажав опеределённые клавиши,
// // можно остановить программу и вывести массив, 
// // либо ответную строку, но вместе их вывести нельзя

// // void ShowcharArray(char[,] charArray) 
// // {
// //     for (int i = 0; i < charArray.GetLength(0); i++)
// //     {
// //         for (int j = 0; j < charArray.GetLength(1); j++)
// //         {
// //             Console.Write(charArray[i, j] + " ");
// //         }
// //         System.Console.WriteLine();
// //     }
// //     System.Console.WriteLine();
// // }

// char[,] InputCharArray()
// {
//     System.Console.WriteLine("Input rows ");
//     int rows = Convert.ToInt32(Console.ReadLine());
//     System.Console.WriteLine("Input colums ");
//     int colums = Convert.ToInt32(Console.ReadLine());
//     char[,] array = new char[rows, colums];
//     Random rand = new Random();
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i, j] = (char) rand.Next('a', 'z' + 1);
//             // System.Console.WriteLine("Input char: "); //ручной ввод символов
//             // array[i, j] = Convert.ToChar(Console.ReadLine());
//         }
//         Console.ReadKey(true);
//     }
//     return array;
// }

// // char[,] array = InputCharArray();
// // ShowcharArray(array);
// System.Console.WriteLine(CharArrayToString(InputCharArray()));

// Задача 2: Задайте строку, содержащую латинские буквы в обоих регистрах. 
// Сформируйте строку, в которой все заглавные буквы заменены на строчные.

// string Letters(string str)
// {
//     string result = string.Empty;
//     for (int i = 0; i < str.Length; i++)
//     {
//         if (str[i] >= 'A' && str[i] <= 'Z')
//         {
//             result = result + (char)(str[i] + 32);
//         }
//         else
//         {
//             result = result + str[i];
//         }
//     }
//     return result;
// }

// System.Console.WriteLine(Letters(Console.ReadLine()));

// Задача 3: Задайте произвольную строку. Выясните, является ли она палиндромом.


// string Palindrome(string str)
// {
//     string Poly = string.Empty;
//     for (int i = 0; i < str.Length; i++)
//     {
//         Poly += str[str.Length - 1 - i];
//     }
//     if ( str == Poly)
//     {
//         return "Yes";
//     }
//     else
//     {
//         return "No";
//     }
// }

// System.Console.WriteLine(Palindrome(Console.ReadLine()));

// Задача 4*(не обязательная): Задайте строку, состоящую из слов, 
// разделенных пробелами. Сформировать строку, в которой слова расположены в обратном порядке. 
// В полученной строке слова должны быть также разделены пробелами.


using System.Collections.Generic;

class Programm
{
    static void Main()
    {
        string s = "Hour of joy";
        string result = ReversWords(s);
        System.Console.WriteLine(result);

    }   

    static string ReversWords(string str)
    {
        string[] subs = str.Split(' ');
        Array.Reverse(subs);
        return string.Join(" ", subs);
    }
}





