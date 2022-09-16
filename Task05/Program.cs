Console.WriteLine("ВВедите целое число");
int N = Convert.ToInt32(Console.ReadLine());
int i = -N;        // i - счетчик
while(i <= N)     // поставили = для того, чтобы последнее число тоже входило 
{
    Console.Write($"{i} ");   // выводит первое число 
    i = i+1;                   // вместо этого можно i++;
}
