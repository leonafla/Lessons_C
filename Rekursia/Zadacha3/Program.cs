//Задайте произвольный массив. Выведете его элементы, начиная с конца. Использовать рекурсию, не использовать циклы.

void PrintArray(int[] array, int index)
{
    if (index < 0) return;
    int a = array[index];
    Console.Write($"{a} ");
    PrintArray(array, index - 1);
}

Console.WriteLine("Введите натуральное число, равное количеству элементов массоива n");
int lengthArray = Convert.ToInt32(Console.ReadLine());

int[] array = new int[lengthArray];
AddNumToArray(array); //заполняем массив случайными числами
Console.WriteLine("");
PrintArray(array, array.Length-1); //выыводим в обратном порядке

void AddNumToArray(int[] array)
{
    Random ran = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = ran.Next(100);
        Console.Write($"{array[i]} ");
    }
}
