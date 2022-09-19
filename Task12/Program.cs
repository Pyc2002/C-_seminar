// 12. Напишите программу, которая будет принимать на
// вход два числа и выводить, является ли первое число
// кратным первому. Если число 2 не кратно числу 1, то
// программа выводит остаток от деления.

// 34, 5 -> не кратно, остаток 4
// 16, 4 -> кратно


int multipleCheck (int numer1, int number2)
{
    int CheckDiv = number1 % number2;
    return CheckDiv;
}

Console.WriteLine("Введите первое число:");
int numA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число:");
int numB = Convert.ToInt32(Console.ReadLine());

