// Задайте массив вещественных чисел.
// Найдите разницу между максимальным и минимальным элементов массива.

double[] getArray(double[] result, int size)
{

    for (int i = 0; i < size; i++)
    {
        result[i] = Math.Round(new Random().NextDouble() * 100, 1);
    }
    return result;
} 

double getArMin(double[] ar, int l) // double getArMin(Массив, длинна массива) 
{
    double min = ar[0];
    for (int i = 0; i < l ; i++)
    {
        if (ar[i] < min)
        {
            min = ar[i];
            i++;
        }
        else
        {
            i++;
        }

    }

    return min;
}

double getArMax(double[] ar, int l)
{
    double max = ar[0];
    for (int i = 0; i < l; i++)
    {
        if (ar[i] > max)
        {
            max = ar[i];
            i++;
        }
        else
        {
            i++;
        }

    }

    return max;
}


Console.WriteLine("Введите длинну массива");
int length = int.Parse(Console.ReadLine());
Console.WriteLine("");
double[] array = getArray(new double[length], length);

for (int i = 0; i < length; i++)
{
    Console.Write(array[i] + " ");
}
Console.WriteLine("");
Console.WriteLine("");
Console.WriteLine("max = " + getArMax(array, length));
Console.WriteLine("min = " + getArMin(array, length));
Console.WriteLine("");
Console.WriteLine($"Max - Min =  {Math.Round(getArMax(array, length) - getArMin(array, length),1)}");



