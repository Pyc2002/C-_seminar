﻿// Напишите программу, которая на вход принимает число (N)
// а на выходе показывает все четные числа от 1 до N.
//
// Пример:
// 5 -> 2, 4
// 8 -> 2 4 6 8


Console.Write("Введите целое положительное число: ");
int N = Convert.ToInt32(Console.ReadLine());

int i = 2;
if (N < 0)
{
    Console.WriteLine("Ошибка! Надо вводить целое положительное число");
}
else
{
    while(i <= N)
    {
        if (i % 2 == 0) Console.Write($"{i} ");
        i++;
    }
}
