/* Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18 */

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

int[,] CreateArray()
{
    Console.Write("Введите количество строк: ");
    int height = Convert.ToInt32(Console.ReadLine()!);
    Console.Write("Введите количество столбцов: ");
    int length = Convert.ToInt32(Console.ReadLine()!);
    Console.Write("Введите минимальное значение: ");
    int minValue = Convert.ToInt32(Console.ReadLine()!);
    Console.Write("Введите максимальное значение: ");
    int maxValue = Convert.ToInt32(Console.ReadLine()!);

    int[,] result = GetArray(height, length, minValue, maxValue);
    return result;
}

int[,] MultiplyMatrix(int[,] arrayOne, int[,] arrayTwo)
{
    int[,] result = new int[arrayOne.GetLength(0), arrayTwo.GetLength(1)];   
    for (int i = 0; i < result.GetLength(0); i++)
    {
        for (int j = 0; j < result.GetLength(1); j++)
        {
            for (int k = 0; k < arrayOne.GetLength(1); k++)
            {
                result[i, j] += arrayOne[i, k] * arrayTwo[k, j];                
            }                      
        }             
    }
    return result;
}

Console.Clear();

int[,] arrayOne = CreateArray();
int[,] arrayTwo = CreateArray();
PrintArray(arrayOne);
Console.WriteLine();
PrintArray(arrayTwo);
Console.WriteLine();
if (arrayOne.GetLength(1) == arrayTwo.GetLength(0))
{
    int[,] productMatrix = MultiplyMatrix(arrayOne, arrayTwo);
    PrintArray(productMatrix);
}
else  Console.WriteLine("Матрицы нельзя умножить");