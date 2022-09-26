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

Console.Write("Введите размер массива: ");
int num = Convert.ToInt32(Console.ReadLine());

int[] arrayGlobal = new int[num];

FillArrayRandom(arrayGlobal);
PrintArray(arrayGlobal);

void FillArrayRandom(int[] array)
{
    Random rnd = new Random();
    for (int i = 0; i <= array.Length - 1; i++)
        array[i] = rnd.Next(0, 2);
}

void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i <= array.Length - 2; i++) Console.Write($"{array[i]},");
    Console.Write($"{array[array.Length - 1]}]");
}
