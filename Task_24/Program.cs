/* Задайте двумерный массив. Напишите программу, 
которая упорядочит по убыванию элементы каждой строки двумерного массива */

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

void SortRows(int[,] array)
{
    int temp;
    for (int i = 0; i < array.GetLength(1); i++)
    {
        for (int j = 1; j < array.GetLength(0); j++)
        {
            for (int k = 0; k < array.GetLength(0) - j; k++)
            {
                if (array[i, k] < array[i, k + 1])
                {
                    temp = array[i, k];
                    array[i, k] = array[i, k + 1];
                    array[i, k + 1] = temp;
                }
            }
        }
    }
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
SortRows(array);
Console.WriteLine();
PrintArray(array);
