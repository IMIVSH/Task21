// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

Console.Clear();

Console.WriteLine("Введите координату x первой точки: ");
int x1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите координату y первой точки: ");
int y1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите координату z первой точки: ");
int z1 = int.Parse(Console.ReadLine());

Console.WriteLine("Введите координату x второй точки: ");
int x2 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите координату y второй точки: ");
int y2 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите координату z второй точки: ");
int z2 = int.Parse(Console.ReadLine());

double getDistanceFromCordinate (int x1, int y1, int x2, int y2, int z1, int z2)
{
    double result = Math.Sqrt(Math.Pow((x2-x1),2) + Math.Pow((y2-y1),2) + Math.Pow((z2-z1),2));
    return result;
}

double distance = getDistanceFromCordinate (x1, y1, x2, y2, z1, z2);
Console.WriteLine($"Расстояние между точками = {Math.Round((distance),2)}.");