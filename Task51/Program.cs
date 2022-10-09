// Задача 51: Задайте двумерный массив. Найдите сумму
// элементов, находящихся на главной диагонали (с индексами
// (0,0); (1;1) и т.д.

int SumDiagonalMatrixElements(int[,] matrix)
{
    // int sum = 0;    
    // for (int i = 0; i < matrix.GetLength(0); i++) 
    // {
    //     for (int j = 0; j < matrix.GetLength(1); j++) 
    //     {
    //         if (i == j) sum += matrix[i, j];
    //     }
    // }
    // return sum;

    int sum = 0;
    int count = matrix.GetLength(0) > matrix.GetLength(1) ? 1 : 0;
    for (int i = 0; i < matrix.GetLength(count); i++) 
        sum += matrix[i, i];
    return sum;
}

int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];
    var rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++) 
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],4} | ");
            else Console.Write($"{matrix[i, j],4} ");
        }
        Console.WriteLine("|");
    }
}

int[,] array2D = CreateMatrixRndInt(3, 4, 0, 10);
PrintMatrix(array2D);
Console.WriteLine($"Сумма диагональных элементов равна {SumDiagonalMatrixElements(array2D)}");

