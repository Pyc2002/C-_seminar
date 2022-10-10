// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:

// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// 1, 7 -> такого элемента в массиве нет


int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];
    var rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++) // 0 - rows  0 
    {
        for (int j = 0; j < matrix.GetLength(1); j++) // 1 - columns
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

void FindElement(int[,] matrix, int numRow, int numColumn)
{
    if (numRow > matrix.GetLength(0) || numColumn > matrix.GetLength(1)) 
    Console.Write($"{numRow}, {numColumn} -> такого элемента в массиве нет");
    else Console.Write($"{numRow}, {numColumn} -> {matrix[numRow - 1, numColumn - 1]}");
}


int[,] array2D = CreateMatrixRndInt(3, 4, 1, 10);
PrintMatrix(array2D);

Console.Write("Введите позицию строки: ");
int rowElem = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите позицию столбца: ");
int columnElem = Convert.ToInt32(Console.ReadLine());

FindElement(array2D, rowElem, columnElem);

//          Вариант без метода с вводом размера массива от пользователя.

// Console.Write("Введите количество строк: ");
// int rowsNum = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите количество столбцов: ");
// int columNum = Convert.ToInt32(Console.ReadLine());

// int[,] array2D = CreateMatrixRndInt(rowsNum, columNum, 1, 10);
// PrintMatrix(array2D);

// Console.Write("Введите позицию строки: ");
// int rowElem = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите позицию столбца: ");
// int columnElem = Convert.ToInt32(Console.ReadLine());

// if (rowElem > rowsNum || columnElem > columNum) Console.Write($"{rowElem}, {columnElem} -> такого элемента в массиве нет");
// else Console.Write($"{rowElem}, {columnElem} -> {array2D[rowElem - 1,columnElem - 1]}");