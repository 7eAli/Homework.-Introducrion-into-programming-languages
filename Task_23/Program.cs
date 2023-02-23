/* Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце */

int[,] GetArray(int height, int length, int minValue, int maxValue)
{
    int[,] result = new int[height, length];

    for (int i = 0; i < height; i++)
    {
        for (int j = 0; j < length; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return result;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]}\t");
        }
        Console.WriteLine();
    }
}

double[] FindColumnAverage(int[,] array)
{
    double[] result = new double[array.GetLength(0)];    
    for (int i = 0; i < array.GetLength(1); i++)
    {
        for (int j = 0; j < array.GetLength(0); j++)
        {
            result[i] += array[j, i];            
        }
        result[i] /= array.GetLength(0);
    }
    return result;
}

Console.Clear();

Console.Write("Введите кол-во строк: ");
int row = int.Parse(Console.ReadLine()!);
Console.Write("Введите кол-во столбцов: ");
int column = int.Parse(Console.ReadLine()!);
Console.Write("Введите минимальное значение: ");
int minValue = int.Parse(Console.ReadLine()!);
Console.Write("Введите максимальное значение: ");
int maxValue = int.Parse(Console.ReadLine()!);

int[,] array = GetArray(row, column, minValue, maxValue);
PrintArray(array);

double[] average =  FindColumnAverage(array);
Console.WriteLine(string.Join("; ", average));
