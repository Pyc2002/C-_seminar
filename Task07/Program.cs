Console.Write("Введите трехзначное число: ");
int num = Convert.ToInt32(Console.ReadLine());

if (num > 100 && num < 1000) // проверка на трехзначность (от 100 до 999)
{
    int res = num % 10;
    Console.WriteLine($"последняя цифра: {res}");
}
else
{
    Console.WriteLine("введено не трехзначное число");
}