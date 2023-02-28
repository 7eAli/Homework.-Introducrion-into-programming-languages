// Напишите программу вычисления функции Аккермана 
// с помощью рекурсии. Даны два неотрицательных числа m и n.

int AckermanFunction(int N, int M)
{
    if (N == 0) return M + 1;
    else if (M == 0) return AckermanFunction(N - 1, 1);
    else return AckermanFunction(N - 1, AckermanFunction(N, M - 1));
}

Console.Clear();
Console.Clear();
Console.Write("Введите N: ");
int N = Convert.ToInt32(Console.ReadLine()!);
Console.Write("Введите M: ");
int M = Convert.ToInt32(Console.ReadLine()!);

int result = AckermanFunction(N, M);
Console.WriteLine(result);