﻿// Задача 26: Напишите программу, которая принимает
// на вход число и выдаёт количество цифр в числе.

// 456 -> 3
// 78 -> 2
// 89126 -> 5

// Console.WriteLine("Введите число: ");
// int number = Convert.ToInt32(Console.ReadLine());

// int sumOfDigits(int num)
// {
//     int count = 1;
//     while(num / 10 != 0)
//     {
//         num = num /10;
//         count++;
//     }
//     return count;
// }
// int result = sumOfDigits(number);
// System.Console.WriteLine($"{result}");

Console.Write("Введите число: ");
int numA = Convert.ToInt32(Console.ReadLine());

int CountDigits (int end)
{
    int counter = 0;
      
    while (end!=0)
    {
        end = end/10;
        counter++;
    }
    return counter;
}

Console.Write($"Количество цифр в числе {numA} равно {CountDigits(numA)}");
