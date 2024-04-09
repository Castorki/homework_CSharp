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


// int FindMax(int num)
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
//             return max;
//         }
//         else
//         {
//             System.Console.WriteLine(max);
//         }
//         return max;
//     }
//     else
//     {
//         System.Console.WriteLine("You input not two-digit number");
//     }
// }

// System.Console.Write("Inpet your number: ");
// int num = Convert.ToInt32(Console.ReadLine());

// System.Console.WriteLine(FindMax(num));

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



