// 11. Напишите программу, которая выводит случайное
// трёхзначное число и удаляет вторую цифру этого
// числа.

// 456 -> 46
// 782 -> 72
// 918 -> 98

// int num = new Random().Next(100,1000);
// Console.WriteLine($"Случайное трехзначное число -> {num}");

// int firstDigit = num / 100;
// Console.WriteLine($"первая цифра -> {firstDigit}");
// int secondDigit = num % 100 / 10;
// Console.WriteLine($"вторая цифра -> {secondDigit}");
// int thirdDigit = num % 10;
// Console.WriteLine($"третья цифра -> {thirdDigit}");

// Console.WriteLine($"{firstDigit}{thirdDigit}");

int Method (int number)
{
    int firstNumber = number / 100 * 10;
    int thirdNumber = number % 10;
    int result = thirdNumber + firstNumber;
    return result;
}
int number = new Random().Next(100,1000);
Console.WriteLine($"Сгенерированное число: {number}");
int bigResult = Method (number);
Console.WriteLine($"число после метода: {bigResult}");