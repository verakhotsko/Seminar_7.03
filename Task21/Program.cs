// Пр-ма, которая на вход принимает координаты двух точек, а 
// на выход выводит расстояние между ними в 3Д-пространстве.

double Distance3D(int X1, int Y1, int Z1, int X2, int Y2, int Z2)
{
   int distX1X2 = X1 - X2;
   int distY1Y2 = Y1 - Y2;
   int distZ1Z2 = Z1 - Z2;
   int sumSquare = distX1X2 * distX1X2 + distY1Y2 * distY1Y2 + distZ1Z2 * distZ1Z2;
   double result = Math.Sqrt(sumSquare);
   return result;
}

Console.Write("Введите координату Х ПЕРВОЙ точки: ");
int coordX1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату Y ПЕРВОЙ точки: ");
int coordY1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату Z ПЕРВОЙ точки: ");
int coordZ1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите координату X ВТОРОЙ точки. ");
int coordX2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату Y ВТОРОЙ точки. ");
int coordY2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату Z ВТОРОЙ точки. ");
int coordZ2 = Convert.ToInt32(Console.ReadLine());

double distanse = Distance3D(coordX1, coordY1, coordZ1, coordX2, coordY2, coordZ2);
double distanseRound = Math.Round(distanse, 2, MidpointRounding.ToZero);
Console.WriteLine(distanseRound);