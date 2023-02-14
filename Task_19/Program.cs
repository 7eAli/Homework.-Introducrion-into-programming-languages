// Напишите программу, которая найдёт точку
// пересечения двух прямых, заданных уравнениями y = k1 *
// x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются
// пользователем

double[] CreateLine()
{
    double[] parameters = new double[2];
    Console.WriteLine("Уравнение прямой y = kx + b");
    Console.Write("Введите k: ");
    parameters[0] = double.Parse(Console.ReadLine()!);
    Console.Write("Введите b: ");
    parameters[1] = double.Parse(Console.ReadLine()!);
    return parameters;
}

double[] LineIntersection(double k1, double b1, double k2, double b2)
{    
    double[] coordinates = new double[2];
    coordinates[0] = (b2 - b1)/(k1 - k2);
    coordinates[1] = k1 * coordinates[0] + b1;
    return coordinates;
}

Console.Clear();
double[] line1 = CreateLine();
double[] line2 = CreateLine();

if(line1[0] == line2[0] && line1[1] != line2[1]) Console.WriteLine("Прямые параллельны");
else if (line1[0] == line2[0] && line1[1] == line2[1]) Console.WriteLine("Прямые совпадают");
else
{
    Console.Write($"Точка пересечения прямых ({string.Join("; ", LineIntersection(line1[0], line1[1], line2[0], line2[1]))})");
}

