// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

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

int[,] MatrixMultiply(int[,] firstMatrix, int[,] secondMatrix)
{
    int[,] resultMatrix = new int[firstMatrix.GetLength(0), secondMatrix.GetLength(1)];
    // if (firstMatrix.GetLength(1) != secondMatrix.GetLength(0)) Console.WriteLine("Ошибка! Число столбцов матрицы 1 не соответствует числу строк матрицы 2");
    // else
    // {


        for (int i = 0; i < firstMatrix.GetLength(0); i++)
        {
            for (int j = 0; j < secondMatrix.GetLength(1); j++)
            {
                int temp = 0;
                for (int k = 0; k < firstMatrix.GetLength(1); k++)
                {
                    temp = temp + firstMatrix[i, k] * secondMatrix[k, j];
                    resultMatrix[i, j] = temp;
                }
            }
        }

    // }
    return resultMatrix;
}




int[,] firstArray2D = CreateMatrixRndInt(3, 3, 0, 10);
PrintMatrix(firstArray2D);
Console.WriteLine("");
int[,] secondArray2D = CreateMatrixRndInt(2, 4, 0, 10);
PrintMatrix(secondArray2D);
Console.WriteLine("");
// int[,] resMatrix = MatrixMultiply(firstArray2D, secondArray2D);
// PrintMatrix(resMatrix);
void Test (int[,] firstMatrix, int[,] secondMatrix)
{
    if (firstMatrix.GetLength(1) != secondMatrix.GetLength(0)) Console.WriteLine("Ошибка! Число столбцов матрицы 1 не соответствует числу строк матрицы 2");
    else
    {
        int[,] resMatrix = MatrixMultiply(firstArray2D, secondArray2D);
        PrintMatrix(resMatrix);
    }
}
Test(firstArray2D, secondArray2D);
