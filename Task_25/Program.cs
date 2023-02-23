/* Задайте прямоугольный двумерный массив. 
Напишите программу, которая будет находить 
строку с наименьшей суммой элементов.
Программа считает сумму элементов в каждой строке 
и выдаёт номер строки с наименьшей суммой элементов: 1 строка */

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

void FindMinRow(int[,] array)
{
    int sum = 0;
    int minimalSum = 0;
    int minimalPosition = 0;
    for (int i = 0; i < array.GetLength(1); i++)
    {
        minimalSum += array[0, i];
    }
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum += array[i, j];            
        }
        if (sum < minimalSum)
        {            
            minimalSum = sum;
            minimalPosition = i;
        }
        sum = 0;
    }
    Console.WriteLine($"Строка с минимальной суммой элементов - № {minimalPosition + 1}");    
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
Console.WriteLine();
FindMinRow(array);

