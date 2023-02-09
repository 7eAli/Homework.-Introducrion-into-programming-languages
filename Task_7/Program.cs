// Задание 15. Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

Console.Clear();

Console.Write("Введите номер дня недели: ");
int day = int.Parse(Console.ReadLine()!);

if (day > 5 && day < 8) Console.WriteLine("Да, это выходной день");
else if (day > 0 && day < 6) Console.WriteLine("Нет, это будний день");
else Console.WriteLine("Вы ввели число, не соответствующее дню недели");