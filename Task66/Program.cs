// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30


Console.WriteLine("Введите первое число:  ");
int numberM = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число:  ");
int numberN = Convert.ToInt32(Console.ReadLine());

int res = default;
if (numberM == numberN) Console.Write("Введенные числа одинаковы!");
else
{
    res = SumElemetsOfNumber(numberM, numberN);
    Console.Write($"Первое число = {numberM}; второе число = {numberN} -> {res}");
}


int SumElemetsOfNumber(int num1, int num2)
{
    int result = num2;
    if (num1 < num2) result += SumElemetsOfNumber(num1, num2 - 1);
    else if (num1 > num2) result += SumElemetsOfNumber(num1, num2 + 1);
    return result;
}