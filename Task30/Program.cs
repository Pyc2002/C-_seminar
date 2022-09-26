// Задача 30: Напишите программу, которая
// выводит массив из 8 элементов, заполненный
// нулями и единицами в случайном порядке.

// [1,0,1,1,0,1,0,0]

// int[]array1 = {1,2,3,4,5,6,7,8};
// int[]array2 = new int[8] {1,2,3,4,5,6,7,8};
// var array3 = new int[8]; // используется только, когда понятен тип данных

// int[] array = new int[8];

// for (int i = 0; i < array.length; i++)
// {
    
// }

int[] array = new int[8];

FillArrayRandom();
PrintArray();

void FillArrayRandom()
{
    for (int i = 0; i <= array.Length - 1; i++) array[i] = new Random().Next(0, 2);
}

void PrintArray()
{
    Console.Write($"[");
    for (int i = 0; i <= array.Length - 2; i++) Console.Write($"{array[i]},");
    Console.Write($"{array[array.Length - 1]}]");
}
