// Задайте одномерный массив, заполненный случайными числами
// Найдите сумму элементов, стоящих на нечётных позициях

int[] GetArray(int size, int minValue, int maxValue)
{
    int[] result = new int[size];

    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(minValue, maxValue + 1);
    }
    return result;
}

int SumOddPosElem(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (i % 2 == 1) sum += array[i];
    }
    return sum;
}

Console.Clear();

int[] array = GetArray(10, -10, 10);
Console.WriteLine(string.Join(", ", array));

Console.WriteLine($"Сумма элементов на нечетых позициях равна {SumOddPosElem(array)}");