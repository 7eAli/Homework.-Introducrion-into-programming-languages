/* Написать программу вычисления произведения чисел от 1 до N */

int factorial(int num)
{
    int prod = 1;     
    if (num == 0) return prod;                                                  
    else                                                                            
    {                                                                                
        for (int i = 1; i <= num; i++)
        {
            prod = prod * i;
        }
        return prod;
    }
}

Console.Clear();

Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine()!);
if (num < 0) Console.WriteLine("Факториала отрицательного числа не существует");    // Вариант, если в условии имелся ввиду факториал.
else                                                                                // Если в условии имелось ввиду последовательное произведение,
{                                                                                   // то пишем Console.WriteLine(0), т.к. от 1 до отрицательного N
    int prod = factorial(num);                                                      // всегда будет проход через 0, обнуляющий все произведение
    Console.WriteLine($"Факториал числа {num} равен {prod}");
}
