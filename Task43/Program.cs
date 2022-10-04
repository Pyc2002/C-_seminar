// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.Write("Введите коэффициент b1: ");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите коэффициент k1: ");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите коэффициент b2: ");
double b2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите коэффициент k2: ");
double k2 = Convert.ToDouble(Console.ReadLine());

// if (k1 == k2 && b1 == b2) Console.Write("Прямые не пересекаются");
// else
// {
    Console.Write($"b1 = {b1}, k1 = {k1}, b2 = {b2}, k2 = {k2}");
    FindIntersectionPoint(b1, k1, b2, k2);
// }
void FindIntersectionPoint(double numb1, double numk1, double numb2, double numk2)
{
    double numx = (b2 - b1) / (k1 - k2);
    double numy = k1 * (b2 - b1) / (k1 - k2) + b1;
    Console.WriteLine($" -> ({numx}; {numy})");
}

