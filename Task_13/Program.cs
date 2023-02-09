/* Показать кубы чисел, заканчивающихся на четную цифру */

// Решение с вводом диапазона чисел
void evenNumToPow3(int num1, int num2)
{
    if (num1 < num2)
    {
        for (int i = num1; i <= num2; i++)
        {
            if (i % 2 == 0)
            {
                Console.Write($"{i * i * i} ");       
                if (num2 % 2 == 1 && i != num2 - 1) Console.Write(", ");
                else if(num2 % 2 == 0 && i != num2) Console.Write(", ");

            }
        }
    }
    else
    {
        for (int i = num2; i <= num1; i++)
        {
            if (i % 2 == 0)
            {
                Console.Write($"{i * i * i} ");
                if (num1 % 2 == 1 && i != num1 - 1) Console.Write(", ");
                else if(num1 % 2 == 0 && i != num1) Console.Write(", ");         
            }
        }
    }
}

Console.Clear();

Console.Write("Введите 1 границу диапазона: ");
int num1 = int.Parse(Console.ReadLine()!);
Console.Write("Введите 2 границу диапазона: ");
int num2 = int.Parse(Console.ReadLine()!);

evenNumToPow3(num1, num2);
