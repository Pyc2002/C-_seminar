// Console.Write("Введите номер дня недели: ");
// string day = Console.ReadLine();

// if (day == "1")
// {
//     Console.WriteLine("понедельник");
// }
// else if (day == "2")
// {
//     Console.WriteLine("вторник");
// }
// else if (day == "3")
// {
//     Console.WriteLine("среда");
// }
// else if (day == "4")
// {
//     Console.WriteLine("четверг");
// }
// else if (day == "5")
// {
//     Console.WriteLine("пятница");
// }
// else if (day == "6")
// {
//     Console.WriteLine("суббота");
// }
// else if (day == "7")
// {
//     Console.WriteLine("воскресенье");
// }
// else
// {
//     Console.WriteLine("Введен неправильный номер дня неделии. Введите число от 1 до 7");
// }

Console.WriteLine("Введите номер дня недели: ");
int day =Convert.ToInt32(Console.ReadLine());

switch (day)
{
    case 1:
    Console.WriteLine("понедельник");
    break;
    case 2:
    Console.WriteLine("втоник");
    break;
    case 3:
    Console.WriteLine("среда");
    break;
    case 4:
    Console.WriteLine("четверг");
    break;
    case 5:
    Console.WriteLine("пятница");
    break;
    case 6:
    Console.WriteLine("суббота");
    break;
    case 7:
    Console.WriteLine("воскресенье");
    break;
    default:
    Console.WriteLine("Введен неправильный номер дня неделии. Введите число от 1 до 7");
    break;
}
