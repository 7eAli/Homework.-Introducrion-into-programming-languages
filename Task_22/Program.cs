/* Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
и возвращает значение этого элемента или же указание, что такого элемента нет */

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

void FindElement(int[,] array)
{
    Console.Write("Строка искомого элемента: ");
    int heightPosition = int.Parse(Console.ReadLine()!);
    Console.Write("Столбец искомого элемента: ");
    int lengthPosition = int.Parse(Console.ReadLine()!);
    if (heightPosition < array.GetLength(0) && lengthPosition < array.GetLength(1))
    {
        Console.WriteLine($"Элемент на позиции ({heightPosition}, {lengthPosition}) имеет значение {array[heightPosition, lengthPosition]}");
    }
    else
    {
        Console.WriteLine("Такого элемента в массиве нет");
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
FindElement(array);
