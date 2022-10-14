// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

int[,] FillSpiralMatrix(int rows, int columns)
{
    int temp = 1;
    int[,] matrix = new int[rows, columns];

    for (int i = 0; i < (matrix.GetLength(0)/2); i++)  //    /2 - для прямоугольных матриц
    {
        for (int j = i; j < (matrix.GetLength(1) - i); j++)
        {
            matrix[i, j] = temp;
            temp++;
        }
        for (int k = 1; k < (matrix.GetLength(0) - i - i); k++)
        {
            matrix[(k + i), (matrix.GetLength(1) - i) - 1] = temp;
            temp++;
        }
        for (int a = (matrix.GetLength(1) - 2) - i; a >= i; a--)
        {
            matrix[(matrix.GetLength(0) - i) - 1, (a)] = temp;
            temp++;
        }
        for (int m = ((matrix.GetLength(0) - i) - 2); m > i; m--)
        {
            matrix[m, i] = temp;
            temp++;
        }
    }
    if (rows % 2 != 0 && columns % 2 != 0)
        matrix[(rows / 2), (columns / 2)] = (rows * columns);      // добавляет последнюю цифру, если матрица квадратная и нечетная

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

int[,] array2D = FillSpiralMatrix(4, 4);
PrintMatrix(array2D);