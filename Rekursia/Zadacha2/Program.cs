//Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

int AkermanFunction(int n, int m)
{
    if (n == 0)
    {
        return m + 1;
    } else if (m == 0)
    {
        return AkermanFunction(n-1, 1);
    } else
    {
        return AkermanFunction(n - 1, AkermanFunction(n, m - 1));
    }
}

Console.WriteLine("Введите n");
int numN = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите m");
int numM = Convert.ToInt32(Console.ReadLine());

int result = AkermanFunction(numN, numM);
Console.WriteLine("Результат функции Аккермана для n = " + numN + " и m = " + numM + " равен " + result);
