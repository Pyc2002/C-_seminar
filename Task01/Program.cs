Console.Write("Введите первое целое цисло: ");
int firstnum = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе целое цисло: ");
int secondnum = Convert.ToInt32(Console.ReadLine());

if (firstnum == secondnum * secondnum)
{
    Console.Write($"число {firstnum} является квадратом {secondnum}");
}
else
{
    Console.Write($"число {firstnum} не является квадратом {secondnum}");
}
