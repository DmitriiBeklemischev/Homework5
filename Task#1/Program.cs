// Задайте массив заполненный случайными положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.

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
int[] array = GetArray(length, 100, 999);
int n = 0;
for (int i = 0; i < length; i++)
{
  Console.Write(array[i] + " ");
}
  foreach (int i in array)
  {
    if (i % 2 == 0)n++;
  }
  Console.WriteLine();
  Console.WriteLine("Количество четных чисел в массиве = " + n);
