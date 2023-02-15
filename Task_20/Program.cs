// Напишите программу, которая
// реализует обход введенного двумерного массива,
// начиная с крайнего нижнего левого элемента против
// часовой стрелки.

int[,] Get2DimArray(int height, int length, int minValue, int maxValue)
{
    int[,] result = new int[height, length];
    for (int i = 0; i < result.GetLength(0); i++)
    {
        for (int j = 0; j < result.GetLength(1); j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return result;
}

void Print2DimArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}

int[] SortArrayAntiClockwise(int[,] array)
{
    int[] result = new int[array.GetLength(1) * array.GetLength(0)];
    int check = 0;
    int passedBotRows = 0;
    int passedRightColumns = 0;
    int passedTopRows = 0;
    int passedLeftColumns = 0;
    while (true)
    {
        for (int i = passedLeftColumns; i < array.GetLength(1) - passedRightColumns; i++) // Заполнение нижней строкой
        {
            result[check] = array[array.GetLength(0) - 1 - passedBotRows, i];
            check++;
            if (check == result.Length) return result;
        }
        passedBotRows++;
        for (int i = passedBotRows; i < array.GetLength(0) - passedTopRows; i++) // Заполнение правым столбцом
        {
            result[check] = array[array.GetLength(0) - i - 1, array.GetLength(1) - passedRightColumns - 1];
            check++;
            if (check == result.Length) return result;
        }
        passedRightColumns++;
        for (int i = passedRightColumns; i < array.GetLength(1) - passedLeftColumns; i++) // Заполнение верхней строкой
        {
            result[check] = array[passedTopRows, array.GetLength(1) - 1 - i];
            check++;
            if (check == result.Length) return result;
        }
        passedTopRows++;
        for (int i = passedTopRows; i < array.GetLength(0) - passedBotRows; i++) // Заполнение левым столбцом
        {
            result[check] = array[i, passedLeftColumns];
            check++;
            if (check == result.Length) return result;
        }
        passedLeftColumns++;
    }    
}

Console.Clear();

int[,] array = Get2DimArray(5, 6, 1, 9);
Print2DimArray(array);
int[] sortedArray = SortArrayAntiClockwise(array);
Console.WriteLine();
Console.WriteLine(string.Join(", ", sortedArray));
