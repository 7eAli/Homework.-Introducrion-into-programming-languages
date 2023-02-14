// Задайте массив вещественных чисел 
//Найдите разницу между максимальным и минимальным элементов массива

double[] GetDoubleArray(int size, double minValue, double maxValue)
{
    double[] result = new double[size];

    for (int i = 0; i < size; i++)
    {
        result[i] = Math.Round(new Random().NextDouble() * ((maxValue + 1) - minValue) + minValue, 2);
    }
    return result;
}

double FindDiff(double[] array)
{
    double max = array[0];
    double min = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] > max) max = array[i];
        else if (array[i] < min) min = array[i];
    }
    return max - min;
}

Console.Clear();

double[] array = GetDoubleArray(10, -100, 100);
Console.WriteLine(string.Join(", ", array));

Console.WriteLine($"Разница между максимальным и минимальным равна {FindDiff(array)}");