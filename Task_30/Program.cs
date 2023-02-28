/* Задайте значения M и N. Напишите программу, которая 
найдёт сумму натуральных элементов в промежутке от M до N. */

int SumNumber(int N, int M)
{
    int result = 0;
    if (N == M) return result += N;
    else if (M > N) return result += M + SumNumber(N, M - 1);
    else return result += N + SumNumber(N - 1, M);
}

Console.Clear();
Console.Write("Введите N: ");
int N = Convert.ToInt32(Console.ReadLine()!);
Console.Write("Введите M: ");
int M = Convert.ToInt32(Console.ReadLine()!);

int sum = SumNumber(N, M);
Console.WriteLine(sum);