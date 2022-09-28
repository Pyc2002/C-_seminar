// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

// Console.WriteLine("Введите число, которое необходимо возвести в степень: ");
// double number = Convert.ToDouble(Console.ReadLine());
// Console.WriteLine("Введите натуральную степень: ");
// double degree = Convert.ToDouble(Console.ReadLine());

//  Для натуральной степени:

// int NumDegree(int num, int deg)
// {
//     int res = 1;
//     for (int i = 1; i <= deg; i++)
//     {
//         res = res * num;
//     }
//     return res;
// }
// int result = NumDegree(number, degree);
// if (degree > 0) Console.WriteLine($"{number} в стпени {degree} -> {result}");
// else Console.WriteLine("Ошибка! Введите натуральную степень");


Console.WriteLine("Введите число, которое необходимо возвести в степень: ");
double number = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите натуральную степень: ");
double degree = Convert.ToDouble(Console.ReadLine());

double result = NumDegree(number, degree);
Console.WriteLine($"{number} в стпени {degree} -> {result}");


double NumDegree(double num, double deg)
{
    double res = 1;
    double totalDeg = 1;
    if (deg < 0)
        totalDeg = -1 * deg;
    else
        totalDeg = deg;

    for (int i = 0; i < totalDeg; ++i)
        res = res * num;

    if (deg < 0)
        res = 1 / res;

    return res;
}