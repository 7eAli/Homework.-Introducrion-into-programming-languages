// Задание 2. Напишите программу, которая на вход принимает два числа и выдаёт, какое число больше, а какое меньшее.

Console.Clear();

Console.WriteLine("Введите 2 числа");
int a = int.Parse(Console.ReadLine());
int b = int.Parse(Console.ReadLine());
int max = a;

if (b > max) max = b;

Console.WriteLine($"max = {max}");