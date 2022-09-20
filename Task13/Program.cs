// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.WriteLine("Введите число");
int num = Convert.ToInt32(Console.ReadLine());

int FindThirdDigit(int number)
{
    while (number > 999) number = number / 10;
    number = number % 10;
    return number;
}

if (num < 100) Console.WriteLine($"В числе {num} третьей цифры нет");
else 
{
int thirdDigit = FindThirdDigit(num);
Console.WriteLine($"В числе {num} третья цифра -> {thirdDigit} ");
}

// if (num < 100) Console.WriteLine($"В числе {num} третьей цифры нет");  // Еще один способ
// else 
// {
//     void FindThirdDigit(int number)
//     {
//     while (number > 999) number = number / 10;
//     Console.WriteLine($"В числе {num} третья цифра -> {number = number % 10} ");
//     return;
//     }
//     FindThirdDigit(num);
// }

