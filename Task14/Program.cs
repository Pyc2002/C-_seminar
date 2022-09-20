// 14. Напишите программу, которая принимает на
// вход число и проверяет, кратно ли оно
// одновременно 7 и 23.
// 14 -> нет
// 46 -> нет
// 161 -> да

Console.WriteLine("Введите число, которое будем проверять: ");
int numCheck = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите первое число, на кратность которого мы будем проверять: ");
int firstNum = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число, на кратность которого мы будем проверять: ");
int secondNum = Convert.ToInt32(Console.ReadLine());

int CheckNumber(int checkArg, int num1, int num2)
{
    int result = 1;
    if (checkArg % num1 == 0 && checkArg % num2 == 0 ) result = 0;
    return result;
}
int resultMethod = CheckNumber(numCheck, firstNum, secondNum);
if (resultMethod == 0) Console.WriteLine ("да");
else Console.WriteLine ("нет");

