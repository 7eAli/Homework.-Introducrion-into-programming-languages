/* Задайте двумерный массив размером m×n, 
   заполненный случайными вещественными числами */

double[,] GetDouble2DimArray(int height, int length, double minValue, double maxValue)
{
    double[,] result = new double[height, length];
    for (int i = 0; i < result.GetLength(0); i++)
    {
        for (int j = 0; j < result.GetLength(1); j++)
        {
            result[i, j] = Math.Round(new Random().NextDouble() * ((maxValue - 1) - minValue) + minValue, 2);
        }
    }
    return result;
}

void Print2DimArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]}\t ");
        }
        Console.WriteLine();
    }
}

Console.Clear();
Console.Write("Введите количество строк: ");
int height = Convert.ToInt32(Console.ReadLine()!);
Console.Write("Введите количество столбцов: ");
int length = Convert.ToInt32(Console.ReadLine()!);
Console.Write("Введите минимальное значение: ");
double minValue = Convert.ToDouble(Console.ReadLine()!);
Console.Write("Введите максимальное значение: ");
double maxValue = Convert.ToDouble(Console.ReadLine()!);

double[,] array = GetDouble2DimArray(height, length, minValue, maxValue);
Print2DimArray(array);
