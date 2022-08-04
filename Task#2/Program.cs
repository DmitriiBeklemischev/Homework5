// Задайте одномерный массив, заполненный случайными числами. 
//Найдите сумму элементов, стоящих на нечётных позициях 

int[] GetArray(int size, int min, int max)
{
    int[] result = new int[size];

    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(min, max + 1);
    }

    return result;
}

Console.WriteLine("Введите длинну массива");
int length = int.Parse(Console.ReadLine());
Console.WriteLine("Введите минимальное число массива");
int min = int.Parse(Console.ReadLine());
Console.WriteLine("Введите максимальное число массива");
int max = int.Parse(Console.ReadLine());
Console.WriteLine();
int[] array = GetArray(length, min, max);
int sum = 0;
for (int i = 0; i < length; i++)
{
    Console.Write(array[i] + " ");
}
for (int i = 0; i < length; i++)
{
    if (i % 2 != 0) sum += array[i];
}
Console.WriteLine();
Console.WriteLine($"Сумма чисел в нечетных позициях = {sum}");