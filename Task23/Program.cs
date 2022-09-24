// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

if (num < 0) Console.WriteLine("Ошибка! Введите положительное число");
else
{
void Cubing (int number)
{
    int index = 1;
    while (index <= number)
    {
        Console.WriteLine($"{index,3} -> {Math.Pow(index,3),5}");
        index++;
    }
    return;
}
Cubing(num);
}
