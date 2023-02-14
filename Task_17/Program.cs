// Разобраться с алгоритмом сортировки методом пузырька
// Реализовать невозрастающую сторировку

int[] GetArray(int size, int minValue, int maxValue)
{
    int[] result = new int[size];

    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(minValue, maxValue + 1);
    }
    return result;
}

void SortArray(int[] array)
{
    int swap = 0;   
    bool check = false;
    while (check == false)
    {
        check = true;
        for(int i = 0; i < array.Length - 1; i++)       
        {            
            if (array[i] < array[i + 1])
            {
                check = false;
                swap = array[i];
                array[i] = array[i + 1];
                array[i + 1] = swap;
            }            
        }        
    }
}

Console.Clear();

int[] array = GetArray(10, -10, 10);
Console.WriteLine(string.Join(", ", array));
SortArray(array);
Console.WriteLine(string.Join(", ", array));
