// Задание 8. Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N

Console.Clear();

Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine());
int output = 0;

while (output < num - 1)
{
    output = output + 2;
    Console.Write($"{output} ");
}

