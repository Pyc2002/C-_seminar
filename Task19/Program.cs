// Задача 19 Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// 14212 -> нет
// 12821 -> да
// 23432 -> да

// Первый вариант:

Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

int Countdown (int number)
{   
    int res = 0;
    while (number > 0)
    {
        res = res * 10 + number % 10;
        number /= 10;                  // number = number / 10;
    }
    return res;
}
    int result = Countdown(num);
    if (num == result) Console.WriteLine($"Да, число {num} - палиндром");
    else Console.WriteLine($"Нет, число {num} -не палиндром");

  
// Второй вариант: 

// Console.WriteLine("Введите пятизначное число: ");
// int num = Convert.ToInt32(Console.ReadLine());
// 
// if(num < 10000 || num > 100000) Console.WriteLine ($"Введено не пятизначное число");
// else
// {
//     void Compare(int number)
//     {
//         if (number / 10000 == number % 10 && number / 1000 % 10 == number / 10 % 10) Console.WriteLine($"Да, число {number} - палиндром");
//         else Console.WriteLine($"Нет, число {number} -не палиндром");
//         return;
//     }
//     Compare(num);
// }