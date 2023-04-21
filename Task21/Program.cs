// добавить Z координату

// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

double DistanceAB(int xa, int ya, int za, int xb, int yb, int zb)
{
    int deltaX = xa - xb;
    int deltaY = ya - yb;
    int deltaZ = za - zb;
    double distAB = Math.Sqrt(deltaX * deltaX + deltaY * deltaY + deltaZ * deltaZ);
    return distAB;
}
Console.WriteLine("Введите координаты точки A ");
Console.Write("Xa: ");
int xAcoordinate = Convert.ToInt32(Console.ReadLine());

Console.Write("Ya: ");
int yAcoordinate = Convert.ToInt32(Console.ReadLine());

Console.Write("Za: ");
int zAcoordinate = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты точки B ");
Console.Write("Xb: ");
int xBcoordinate = Convert.ToInt32(Console.ReadLine());

Console.Write("Yb: ");
int yBcoordinate = Convert.ToInt32(Console.ReadLine());

Console.Write("Zb: ");
int zBcoordinate = Convert.ToInt32(Console.ReadLine());

double distanceAB = DistanceAB(xAcoordinate, yAcoordinate, zAcoordinate, xBcoordinate, yBcoordinate, zBcoordinate);
double distRound = Math.Round(distanceAB, 2, MidpointRounding.ToZero);
Console.WriteLine(distRound);