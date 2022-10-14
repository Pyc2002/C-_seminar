// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 27(0,0,1) 25(0,1,0) 90(0,1,1)
// 34(1,0,0) 26(1,0,1) 41(1,1,0) 55(1,1,1)


int[] FillArray(int min, int max)
{
    Random rnd = new Random();
    int[] array = new int[max - min];
    array[0] = rnd.Next(min, max);
    for (int i = 1; i < array.Length;)
    {
        int temp = rnd.Next(min, max); 
        int j = 0;

        for (j = 0; j < i; j++)
        {
            if (temp == array[j])
                break;
        }
        if (j == i)
        {
            array[i] = temp;
            i++;
        }
    }

    return array;
}


int[,,] Resault3DMatrix(int[] array, int rows, int columns, int depth)
{
    int[,,] matrix3d = new int[rows, columns, depth];
    int index = 0;
    for (int i = 0; i < matrix3d.GetLength(0); i++)
    {
        for (int j = 0; j < matrix3d.GetLength(1); j++)
        {
            for (int k = 0; k < matrix3d.GetLength(2); k++)
            {
                matrix3d[i, j, k] = array[index];
                index++;
            }
        }
    }
    return matrix3d;
}



void PrintMatrix(int[,,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(" |");
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                if (k < matrix.GetLength(2) - 1) Console.Write($"{matrix[i, j, k],4} ({i},{j},{k}) | ");
                else Console.Write($"{matrix[i, j, k],4} ({i},{j},{k})");
            }
        }
        Console.WriteLine(" |");
    }
}

void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i <= array.Length - 2; i++) Console.Write($"{array[i]},");
    Console.Write($"{array[array.Length - 1]}]");
}


int[] arr = FillArray(10, 40);
PrintArray(arr);
Console.WriteLine("");
Console.WriteLine("");
int[,,] matrix3D = Resault3DMatrix(arr, 3, 3, 3);
PrintMatrix(matrix3D);

