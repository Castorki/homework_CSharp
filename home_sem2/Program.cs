// void CheckIfDevides(int num)
// {
//     int num1 = 7; 
//     int num2 = 23;
//     if (num % num1 == 0 && num % num2 == 0)
//     {
//         System.Console.WriteLine("Your number ia a multiple of 7 and 23");
//     }
//     else
//     {
//         System.Console.WriteLine("Your number ia not a multiple of 7 and 23");
//     }
// }

// Console.Write("Input your number: ");
// int num = Convert.ToInt32(Console.ReadLine());

// CheckIfDevides(num);


// using System;

// class Program
// {
//     static int CheckIfDevides(int num)
//     {
//         int num1 = 7;
//         int num2 = 35;
//         if (num % num1 == 0 && num % num2 == 0)
//         {
//             System.Console.WriteLine("Your number ia a multiple of 7 and 23");
//             return num;
//         }
//         else
//         {
//             System.Console.WriteLine("Your number ia not a multiple of 7 and 23");
//             return -1;
//         }
//     }

//     static void Main()
//     {
//         System.Console.Write("Input your number: ");
//         int num = Convert.ToInt32(Console.ReadLine());
//         int Mult = CheckIfDevides(num);
//         if (Mult != -1)
//         {
//             System.Console.WriteLine(Mult);
//         }
//     }
// }



// Задача 3: Напишите программу, которая принимает на вход целое число из отрезка [10, 99] 
// и показывает наибольшую цифру числа.

// void FinxdMa(int num)
// {
//     if (num >= 10 && num <= 99)
//     {
//         int ed = num / 10;
//         int dec = num % 10;
//         int max = ed;
//         if (ed < dec)
//         {
//             max = dec;
//             System.Console.WriteLine(max);
//         }
//         else
//         {
//             System.Console.WriteLine(max);
//         }
//     }
//     else
//     {
//         System.Console.WriteLine("You input not two-digit number");
//     }
// }

// System.Console.Write("Inpet your number: ");
// int num = Convert.ToInt32(Console.ReadLine());

// FinxdMa(num);

// using System;

// class Program
// {
//     static int FindMax(int num)
//     {
//         if (num >= 10 && num <= 99)
//         {
//             int ed = num / 10;
//             int dec = num % 10;
//             int max = ed;
//             if (ed < dec)
//             {
//                 max = dec;
//             }
//             return max;
//         }
//         else
//         {
//             System.Console.WriteLine("You input not two-digit number");
//             return -1;
//         }
//     }

//     static void Main()
//     {
//         System.Console.Write("Input your number: ");
//         int num = Convert.ToInt32(Console.ReadLine());
//         int MaxDigit = FindMax(num);
//         if (MaxDigit != -1)
//         {
//             System.Console.WriteLine("Максимальная цифра: " + MaxDigit);
//         }

//     }
// }


// Задача 4: Напишите программу, которая на вход принимает натуральное число N, 
// а на выходе показывает его цифры через запятую.

// void Haptfu(int num)
// {
//     int start = 0;
//     while (start <= num)
//     {
//         System.Console.Write(start + ", " );
//         start ++;
//     }
// }

// System.Console.Write("Input your number: ");
// int num = Convert.ToInt32(System.Console.ReadLine());

// Haptfu(num);

// using System;

// class Program
// {
//     static int Haptfu(int num)
//     {
//         int start = 0;
//         while (start < num)
//         {
//             System.Console.Write(start + ", ");
//             start ++;
//         }
//         return start;
//     }

//     static void Main()
//     {
//         System.Console.Write("Input your number: ");
//         int num = Convert.ToInt32(Console.ReadLine());
//         System.Console.WriteLine(Haptfu(num));
//     }
// }

// Задача 2: Напишите программу, которая принимает на вход координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 
// и выдаёт номер координатной четверти плоскости, в которой находится эта точка.


// void Hrgf(int x, int y)
// {
//     if (x > 0 && y > 0)
//     {
//         System.Console.WriteLine("1");
//     }
//     else if (x < 0 && y >0 )
//     {
//         System.Console.WriteLine("2");
//     }
//     else if (x < 0 && y < 0)
//     {
//         System.Console.WriteLine("3");
//     }
//     else if (x > 0 && y < 0)
//     {
//         System.Console.WriteLine("4");
//     }
//     else
//     {
//         System.Console.WriteLine("The point is on the coordinate axis");
//     }
// }

// System.Console.WriteLine("Input coordinate x: ");
// int x = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Input coordinate y: ");
// int y = Convert.ToInt32(Console.ReadLine());


// Hrgf(x, y);

using System;

class Program
{
    static int coordinates(int x, int y)
    {
        if (x > 0 && y > 0)
        {
            System.Console.WriteLine("1");
            return x & y;
        }
        else if (x < 0 && y > 0)
        {
            System.Console.WriteLine("2");
            return x & y;
        }
        else if (x < 0 && y < 0)
        {
            System.Console.WriteLine("3");
            return x & y;
        } 
        else if (x > 0 && y < 0)
        {
            System.Console.WriteLine("4");
            return x & y;
        }
        else
        {
            System.Console.WriteLine("The point is on the coordinate axis");
            return -1;
        }
    }

    static void Main()
    {
        System.Console.WriteLine("Input coordinate x: ");
        int x = Convert.ToInt32(Console.ReadLine());
        System.Console.WriteLine("Input coordinate y: ");
        int y = Convert.ToInt32(Console.ReadLine());
        System.Console.WriteLine(coordinates(x, y));
    }
}

// using System;

// class Program
// {
//     static int FindMax(int num) // Собственно наша функция по нахождению максималки.
//     {
//         if (num >= 10 && num <= 99) // Проверка на двухзначность с диапазоном. Если не прошли, идём в блок "ELSE"
//         {
//             int ed = num / 10;  // Присвоение первой цифры.
//             int dec = num % 10; // Присвоение второй цифры.
//             int max = ed;       // По умолчанию делаем НАИВЫСШЕЙ первую цифру.
//             if (ed < dec)       // Проверка что первая цифра меньше второй цифры.
//             {
//                 max = dec;      // Если ДА то присваиваем вторую цифру как НАИВЫСШУЮ!
//             }
//             return max;         // Возвращаем НАИВЫСШУЮ!
//         }
//         else
//         {
//             Console.WriteLine("You input not two-digit number"); // Пишем пользователю что он идиот. 
//             return -1;                                           // Возвращаем ему порицательную "-1"
//         }                                                        // -- Потому что мы должны что-то вернуть. (Это для машины)
//     }

//         static void Main() // Точка входа в нашу программу. Без неё компилятор не понимает где тут начало?
//     {
//         Console.Write("Давай своё число... ");          // Пишем пользователю запрос на число.
//         int num = Convert.ToInt32(Console.ReadLine());  // Конвертируем полученную строку в число.
//                                                         // (Разные типы данных, это важно, особенно в языках со строгой типизацией)
//         int maxDigit = FindMax(num);                    // Присваиваем РЕЗУЛЬТАТ работы выше описанной функции. (Вот тут то и нужен RETURN иначе функция отработала бы и вернула НИЧЕГО (NONE) )
//         if (maxDigit != -1)                             // Проверка что в ответе пришло не ПОРИЦАТЕЛЬНОЕ "-1" Что означало бы что пользователь идиот.
//         {
//             Console.WriteLine("Максимальная цифра тут: " + maxDigit); // Выводим в консоль результат всей деятельности.
//         }
//     }
// }