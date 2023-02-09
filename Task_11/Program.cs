/* Подсчитать сумму цифр в числе */

int digSumCounter(int num)
{
    int sum = 0;    
    if (num < 0) num = -num;    
    while(num != 0)
    {
        sum = sum + num % 10;
        num = num / 10;
    }
    return sum;
}

Console.Clear();

Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine()!);
int sum = digSumCounter(num);
Console.Write($"Сумма цифр числа {num} равна {sum}");


