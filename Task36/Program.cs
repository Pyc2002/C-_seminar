// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

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

int[] arr = CreateArrayRndInt(6, -100, 100);

int SumNumbersOnOddIndex(int[] array)
{
   int count = default;
   for (int i = 0; i < array.Length; i++)
   {
        if (i % 2 == 1) count = count + array[i];
   }
   return count;
}

PrintArray(arr);
int result = SumNumbersOnOddIndex(arr);
Console.Write($" -> Сумма числел на нечетных позициях в массиве: {result}");