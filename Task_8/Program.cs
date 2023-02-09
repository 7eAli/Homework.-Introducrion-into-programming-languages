/* Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом */

Console.Clear();

Console.Write("Введите пятизначное число: ");
int num = Convert.ToInt32(Console.ReadLine()!);
if (num < 0) num = -num;

if (num < 9999 && num > 99999) Console.WriteLine("Вы ввели неправильное число");
else
{    
    int dig1 = num % 10;
    int dig2 = (num / 10) % 10;
    int dig4 = (num / 1000) % 10;
    int dig5 = num / 10000;
    if (dig1 == dig5 && dig2 == dig4) Console.WriteLine("Число является палиндромом");
    else Console.WriteLine("Число не является палиндромом");
}

