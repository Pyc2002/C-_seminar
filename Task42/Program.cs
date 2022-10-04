// Задача 42: Напишите программу, которая будет преобразовывать
// десятичное число в двоичное.
// 45 -> 101101
// 3 -> 11
// 2 -> 10


Console.Write("Введите целое положительное число:");
int numA = Convert.ToInt32(Console.ReadLine());

// void ConvertToBin(int num)
// {
//     string bin = default;

//     if (num > 0)
//     {
//         if (num % 2 == 1) bin += "1";
//             else bin+= "0";
//         ConvertToBin(num / 2);    
//     }
//      Console.Write(bin);
// }

void ConvertToBin2(int num)
{
    string bin = default;

     if (num > 0)
     {
        bin += num % 2;         
        ConvertToBin2(num / 2);    
     }   

    Console.Write(bin);
}

// ConvertToBin(numA);
ConvertToBin2(numA);
