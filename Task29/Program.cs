// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

Console.Write("Введите размер массива: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите начало массива: ");
int first = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите конец массива: ");
int end = Convert.ToInt32(Console.ReadLine());

int[] array = new int[n];

void FillArrayRandom(int[] arr, int begin, int last)
{
    Random rnd = new Random();
    for (int i = 0; i <= arr.Length - 1; i++)
        array[i] = rnd.Next(begin, last);
}

void PrintArray(int[] arr1)
{
    Console.Write("[");
    for (int i = 0; i <= arr1.Length - 2; i++) Console.Write($"{arr1[i]},");
    Console.Write($"{arr1[arr1.Length - 1]}]");
}

FillArrayRandom(array, first, end);
PrintArray(array);
