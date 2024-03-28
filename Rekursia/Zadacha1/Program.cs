//Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N. 
//Использовать рекурсию, не использовать циклы.

void PrintNaturalNumber(int start, int end)
{
        if (start == end + 1) return;
        Console.Write($"{start} ");
        PrintNaturalNumber(start + 1, end);
}

Console.WriteLine("Введите N");
int numN = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите M");
int numM = Convert.ToInt32(Console.ReadLine());

if (numN < numM)
{
    PrintNaturalNumber(numN, numM);
}
else if (numN > numM)
{
    PrintNaturalNumber(numM, numN);
}
else 
{
   Console.Write($"{numM} == {numN}"); 
}
