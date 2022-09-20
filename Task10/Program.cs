// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.WriteLine("Введите трехзначное число");
int num = Convert.ToInt32(Console.ReadLine());

void FindSecondDigit(int number)
{
    int secondDigit = 0;
    if (number > 99 && number < 1000)
    {
        secondDigit = number % 100 / 10;
        Console.WriteLine($"Вторая цифра числа {number} -> {secondDigit}");
    }
    else Console.WriteLine("Введено не трехзначное число");
    return;
}
FindSecondDigit(num);
