// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int DigitSum(int num)
{
    int res = 0;
    for (int i = 0; num != 0; i++)
    {
        int digit = num % 10;
        num = num / 10;
        res = res + digit;
    }
    if (res < 0) res *= -1;                     //  чтобы не было отрицательного результата, если введено отрицательное число
    return res;
}
int result = DigitSum(number);
Console.Write($"Сумма цифр числа {number} -> {result} ");
