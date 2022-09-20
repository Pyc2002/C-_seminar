// 16. Напишите программу, которая принимает на
// вход два числа и проверяет, является ли одно
// число квадратом другого.
// 5, 25 -> да
// -4, 16 -> да
// 25, 5 -> да
// 8,9 -> нет


Console.WriteLine("Введите первое число: ");
int firstNum = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int secondNum = Convert.ToInt32(Console.ReadLine());

void CheckSqure (int num1, int num2)
{
    // int sqr = num1 < num2 ? sqr = num1 * num1 : sqr = num2 * num2;
    
    // if (sqr == num2 || sqr == num1) Console.WriteLine("да");
    // else Console.WriteLine("нет");

    int sqr = 0;
    if (num1 < num2) 
    {sqr = num1 * num1;
        if (sqr == num2) Console.WriteLine($"число {num1} является квадратом числа {num2}");
        else Console.WriteLine($"число {num1} не является квадратом числа {num2}");
    }
    else 
    { sqr = num2 * num2;
        if (sqr == num1) Console.WriteLine($"число {num2} является квадратом числа {num1}");
        else Console.WriteLine($"число {num1} не является квадратом числа {num2}");
    }
}
CheckSqure(firstNum,secondNum);
