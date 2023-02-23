/* Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента */

int[,,] CreateArray()
{
    Console.Write("Введите 1 размерность массива: ");
    int height = int.Parse(Console.ReadLine()!);
    Console.Write("Введите 2 размерность массива: ");
    int length = int.Parse(Console.ReadLine()!);
    Console.Write("Введите 3 размерность массива: ");
    int width = int.Parse(Console.ReadLine()!);
    int[,,] result = new int[height, length, width];
    int filling = 10;
    for (int i = 0; i < result.GetLength(0); i++)
    {
        for (int j = 0; j < result.GetLength(1); j++)
        {
            for (int k = 0; k < result.GetLength(2); k++)
            {
                result[i, j, k] = filling;
                filling++;
            }
        }
    }
    return result;
}

void PrintArray(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                Console.Write($"{array[i, j, k]}({i}, {j}, {k}) ");
            }
            Console.WriteLine();
        }
    }
}

Console.Clear();

int[,,] array = CreateArray();
PrintArray(array);