//Задача 4: Напишите программу, которая на вход принимает натуральное число N, а на выходе показывает его цифры через запятую.
Console.WriteLine("Введите целое натуральное число");
int num = Convert.ToInt32(Console.ReadLine());
string res = "";
int ost = num / 10;
if (ost == 0)
{
    Console.WriteLine($"{num} => {num}");
}
else
{
    int numRes = num;
    bool firstIn = true;
    while (numRes > 0)
    {
        if (firstIn)
        {
            res = Convert.ToString(numRes % 10);
            firstIn = false;
            numRes = numRes / 10;
        }
        else
        {
            res = Convert.ToString(numRes % 10) + "," + res;
            numRes = numRes / 10;
        }
    }
    Console.WriteLine($"{num} => {res}");
}