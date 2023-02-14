// Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.

int[] CreateArray(int size)
{
    int[] result = new int[size];
    for (int i = 0; i < size; i++)
    {
        Console.Write($"Введите {i + 1}-е число массива: ");
        result[i] = Convert.ToInt32(Console.ReadLine()!);
    }
    return result;
}

int CountPositive(int[] array)
{
    int count = 0;
    for (int j = 0; j < array.Length; j++)
    {
        if (array[j] > 0) count++;
    }
    return count;
}


Console.Clear();
int[] array = CreateArray(5);
Console.WriteLine(string.Join(", ", array));
Console.WriteLine($"Положительных чисел: {CountPositive(array)}");