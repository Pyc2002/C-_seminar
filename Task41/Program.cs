// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3


int[] CreateArray(int size)
{
    int[] array = new int[size];
 
    for (int i = 0; i < size; i++)
    {
        Console.WriteLine($"Введите {i + 1} число: ");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
    return array;
}

            // Второй способ ввода массива (отключить строчки 41, 42, 44):

// Console.WriteLine("Введите все значения массива через пробел и нажмите enter");
// int[] arr = Console.ReadLine().Split(' ').Select(i => int.Parse(i)).ToArray();

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"{array[i]}, ");
        else Console.Write($"{array[i]} ");
    }
}

int CountOddNumbers(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    if (array[i] > 0) sum++;
    return sum;
}

Console.WriteLine("Введите общее количество чисел: ");
int arrsize = Convert.ToInt32(Console.ReadLine());

int [] arr = CreateArray(arrsize);
int resault = CountOddNumbers(arr);
PrintArray(arr);
Console.Write($" -> {resault}");