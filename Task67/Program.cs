// Задача 67: Напишите программу, которая будет принимать на вход число и
// возвращать сумму его цифр.
// 453 -> 12
// 45 -> 9

// Console.Write("Введите число:  ");
// int num = Convert.ToInt32(Console.ReadLine());
// int resault = DigitsSum(num);
// Console.Write($"{num} -> {resault}");

// int DigitsSum(int number)
// {
//     if (number == 0) return 0;
//     number = number % 10 + DigitsSum(number / 10);

//     return number;
// }

int SumOfDig(int num)
{
    int result =num % 10; 
    
    if (num != 0) result += SumOfDig(num / 10); 
    return result;
}

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int sum = SumOfDig(number);
Console.WriteLine($"{number} -> {sum}");
