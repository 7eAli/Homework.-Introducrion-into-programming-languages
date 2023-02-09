/* Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве */
Console.Clear();
Console.Write("Введите Xa: ");
int Xa = int.Parse(Console.ReadLine()!);
Console.Write("Введите Ya: ");
int Ya = int.Parse(Console.ReadLine()!);
Console.Write("Введите Za: ");
int Za = int.Parse(Console.ReadLine()!);
Console.Write("Введите Xb: ");
int Xb = int.Parse(Console.ReadLine()!);
Console.Write("Введите Yb: ");
int Yb = int.Parse(Console.ReadLine()!);
Console.Write("Введите Zb: ");
int Zb = int.Parse(Console.ReadLine()!);

double distance = Math.Round(Math.Sqrt((Xa - Xb)*(Xa - Xb) + (Ya - Yb)*(Ya - Yb) + (Za - Zb)*(Za - Zb)), 2);
Console.WriteLine($"Расстояние между А и Б равно {distance}");