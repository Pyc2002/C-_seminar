// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет


// Первый способ без дней недели:

// Console.WriteLine("Введите номер дня недели: "); 
// int day = Convert.ToInt32(Console.ReadLine());

// if (day < 1 || day > 7) Console.WriteLine("Введен неправильный номер дня неделии. Введите число от 1 до 7"); 
// else if (day == 6 || day == 7) Console.WriteLine("Да, выходной");
// else Console.WriteLine("Нет, не выходной");

// Второй способ:

Console.Write("Введите номер дня недели: ");
string day = Console.ReadLine();

if (day == "1") Console.WriteLine("Нет, понедельник - не выходной");
else if (day == "2") Console.WriteLine("Нет, вторник - не выходной");
else if (day == "3") Console.WriteLine("Нет, среда - не выходной");
else if (day == "4") Console.WriteLine("Нет, четверг - не выходной");
else if (day == "5") Console.WriteLine("Нет, пятница - не выходной");
else if (day == "6") Console.WriteLine("Да, суббота - выходной");
else if (day == "7") Console.WriteLine("Да, воскресенье - выходной");
else Console.WriteLine("Введен неправильный номер дня неделии. Введите число от 1 до 7");

