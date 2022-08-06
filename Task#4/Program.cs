// Найдите произведение пар чисел в одномерном массиве.
// Парой считаем первый и последний элемент,
// второй и предпоследний и т.д. Результат запишите в новом массиве.

int[] getArray(int size, int min, int max)
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

int[] array = getArray(length, -5, 5);

for (int i = 0; i < length; i++)
{
    Console.Write(array[i] + " ");
}
Console.WriteLine("");
int res1 = array[0] * array[^1];
int res2 = array[1] * array[^2];

Console.WriteLine("Произведение первой пары = " +res1);
Console.WriteLine("Произведение второй пары = " +res2);
Console.WriteLine("");
int[] res = new int[2];
res[0] = res1;
res[1] = res2;
for (int n = 0; n < 2; n++)
{
    Console.Write($"{res[n]} ");
}
