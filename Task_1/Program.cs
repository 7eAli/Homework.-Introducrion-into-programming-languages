// Задание 2. Напишите программу, которая на вход принимает два числа и выдаёт, какое число больше, а какое меньшее.

Console.Clear();

Console.Write("Введите число: ");
int a = int.Parse(Console.ReadLine());
Console.Write("Введите число: ");
int b = int.Parse(Console.ReadLine());
int max = a;

if (b > max) max = b;

Console.WriteLine($"max = {max}");