// Задача 69: Напишите программу, которая на вход принимает два числа A и B, и
// возводит число А в целую степень B с помощью рекурсии.
// A = 3; B = 5 -> 243 (3⁵)
// A = 2; B = 3 -> 8

int HandPow(int num, int power) //453  //45
{
    int result = num; /// 3
    if (power == 0 ) return 1;
    else if (power != 1) result = num * HandPow(num, power -1 );
    return result ;
}

Console.Write("Введите число:  ");
int number = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите степень:  ");
int sqr = Convert.ToInt32(Console.ReadLine());

int res = HandPow(number, sqr);
Console.WriteLine($"Число {number} в степени {sqr} равно: {res}");

// Console.Write("Введите число:  ");
// int number1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите степень числа:  ");
// int number2 = Convert.ToInt32(Console.ReadLine());

// int deegreNumber = DegreeNumber (number1, number2);
// Console.WriteLine (deegreNumber);
// int DegreeNumber (int numb1, int numb2)
// {
//     return numb2 == 0 ? 1 : numb1 * DegreeNumber (numb1, numb2-1); - тернарный оператор
//     // if (numb2 == 0) return 1;
//     // return numb1 = numb1 * DegreeNumber (numb1, numb2-1);
// }
