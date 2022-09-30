// Задача 33: Задайте массив. Напишите программу, которая
// определяет, присутствует ли заданное число в массиве.

// 4; массив [6, 7, 19, 345, 3] -> нет
// 3; массив [6, 7, 19, 345, 3] -> да

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

Console.Write("Введите искомое число в массиве: ");
int num = Convert.ToInt32(Console.ReadLine());

bool FindDigit(int[] array, int number)
{
    for (int i = 0; i < array.Length; i++)
    
        if (number == array[i]) return true;
        return false;
    
}

int[] arrayGlobal = CreateArrayRndInt(10, -3, 3);

PrintArray(arrayGlobal);
if (FindDigit(arrayGlobal, num))
    Console.WriteLine(" -> Да");
else Console.WriteLine(" -> Нет");
