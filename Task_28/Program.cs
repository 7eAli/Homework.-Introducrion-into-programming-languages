/* Напишите программу, которая заполнит спирально массив 4 на 4 */

void FillArrayClockwise(int[,] array)
{
    int passedTopRows = 0;
    int passedRightColumns = 0;
    int passedBotRows = 0;
    int passedLeftColumns = 0;
    int check = 0;
    while (check < array.GetLength(0) * array.GetLength(1))
    {
        for (int i = passedLeftColumns; i < array.GetLength(1) - passedRightColumns; i++)
        {
            array[passedTopRows, i] = check + 1;            
            check++;
        }
        passedTopRows++;
        for (int j = passedTopRows; j < array.GetLength(0) - passedBotRows; j++)
        {
            array[j, array.GetLength(0) - passedRightColumns - 1] = check + 1;            
            check++;
        }
        passedRightColumns++;
        for (int k = passedRightColumns; k < array.GetLength(1) - passedLeftColumns; k++)
        {
            array[array.GetLength(1) - passedBotRows - 1, array.GetLength(0) - k - 1] = check + 1;           
            check++;
        }
        passedBotRows++;
        for (int m = passedBotRows; m < array.GetLength(0) - passedTopRows; m++)
        {
            array[array.GetLength(0) - m - 1, passedLeftColumns] = check + 1;            
            check++;
        }
        passedLeftColumns++;
    }
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

Console.Clear();
int[,] array = new int[4, 4];

FillArrayClockwise(array);
PrintArray(array);