// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

int[] CreateArrayRndInt(int size, int min, int max)
{
    int[] array = new int[size];
    var rnd = new Random();

    for (int i = 0; i < size; i++)
    {
        array[i] = rnd.Next(min, max + 1);
    }
    return array;
}

void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i <= array.Length - 2; i++) Console.Write($"{array[i]},");
    Console.Write($"{array[array.Length - 1]}]");
}

int[] arr = CreateArrayRndInt(5, 100, 999);

int FindEvenNumbers(int[] array)
{
   int count = default;
   for (int i = 0; i < array.Length; i++)
   {
        if (array[i] %2 == 0) count++;
   }
   return count;
}

PrintArray(arr);
int result = FindEvenNumbers(arr);
Console.Write($" -> Четных числел в массиве: {result}");
