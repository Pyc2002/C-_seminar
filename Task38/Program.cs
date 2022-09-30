// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

// [3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2

System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US"); // для получения . вместо , в дробных числах.
double[] CreateArrayRndInt(int size, double min, double max)
{
    double[] array = new double[size];
    var rnd = new Random();

    for (int i = 0; i < size; i++)
    {
        array[i] = Math.Round(rnd.NextDouble() * (max - min) + min, 1);
    }
    return array;
}

void PrintArray(double[] array)
{
    Console.Write("[");
    for (int i = 0; i <= array.Length - 2; i++) Console.Write($"{array[i]}, ");
    Console.Write($"{array[array.Length - 1]}]");
}

double[] arr = CreateArrayRndInt(5, 1, 100);


//          Способ 1: объединенный метод

// double DifferenceMaxMinElements (double [] array)
// {
//     double max = array[0];
//     double min = array[0];
//     double result = default;

//     for (int i = 0; i < array.Length; i++)
//     {
//         if(array[i] > max) max = array[i];
//         if(array[i] < min) min = array[i];
//     }
//      result = max - min;
//     return result;
// }
// double res = DifferenceMaxMinElements (arr);
// PrintArray(arr);
// Console.Write($" -> разница макс и минимального элементов: {Math.Round(res, 1)}");

//          Способ 2:


double FindMaxElemets(double[] array)
{
    double max = array[0];
    for (int i = 0; i < array.Length; i++)
        if (array[i] > max) max = array[i];
    return max;
}

double FindMinElemets(double[] array)
{
    double min = array[0];
    for (int i = 0; i < array.Length; i++)
        if (array[i] < min) min = array[i];
    return min;
}
double maxElem = FindMaxElemets(arr);
double minElem = FindMinElemets(arr);

PrintArray(arr);
Console.Write($" -> разница макс и минимального элементов: {Math.Round(maxElem - minElem, 1)}");

