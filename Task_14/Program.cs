// Задайте массив заполненный случайными положительными трёхзначными числами
// Напишите программу, которая покажет количество чётных чисел в массиве

int[] GetArray(int size, int minValue, int maxValue)
{
    int[] result = new int[size];

    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(minValue, maxValue + 1);
    }
    return result;
}

int CheckEven(int[] array)
{
    int result = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0) result += 1;        
    }
    return result;
}

Console.Clear();

int[] array = GetArray(10, 100, 999);
Console.WriteLine(string.Join(", ", array));

int evenFromArray = CheckEven(array);
Console.WriteLine($"Количетсво четных чисел в массиве: {evenFromArray}");