// Задание 13. Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет
Console.Clear();

Console.Write("Введите число: ");
int a = int.Parse(Console.ReadLine());

if (a < 100 && a > -100) Console.WriteLine("Третьей цифры нет");
else
{
    while (a > 999 || a < -999)
    {
        a = a / 10;
    }
    a = a % 10;
    if (a < 0) a = -a;
    Console.WriteLine($"Третья цифра {a}");
}
