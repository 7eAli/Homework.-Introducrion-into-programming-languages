/* Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N */
Console.Clear();
Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine()!);
int counter = 1;

if (num > 0)
{
    while(num >= counter)
    {
        Console.Write($"{counter * counter * counter}");
        if (num != counter) Console.Write(", ");
        counter += 1;
    }
}
else
{
    while(num <= counter)
    {
        Console.Write($"{counter * counter * counter}");
        if (num != counter) Console.Write(", ");
        counter -= 1;
    }
}
