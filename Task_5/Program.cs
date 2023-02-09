// Задание 10. Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа
Console.Clear();

Console.Write("Введите трехзначное число: ");
int num = int.Parse(Console.ReadLine()!);
int digit_2 = 0;

if (num < 0) num = -num;
if (num > 99 && num < 1000) Console.WriteLine(digit_2 = (num - (num / 100 * 100) - (num % 10))/10);
else Console.WriteLine("Вы ввели не трехзначное число");

