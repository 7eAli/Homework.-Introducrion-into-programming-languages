// Задайте значение N. Напишите программу, которая выведет 
// все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

void ShowNumbers(int N)
{
    if (N == 1)
    {
        Console.Write(1);
        return;
    }
    else
    {
        Console.Write($"{N}, ");
        ShowNumbers(N - 1);
        return;
    }
}

Console.Clear();
Console.Write("Введите число: ");
int N = int.Parse(Console.ReadLine()!);
ShowNumbers(N);
