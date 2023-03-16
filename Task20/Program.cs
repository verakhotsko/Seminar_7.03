// Пр-ма, которая на вход принимает координаты двух точек и 
// на выход выводит расстояние между ними в 2Д пространстве.

double Distance(int X1, int Y1, int X2, int Y2)
{
   int distX1X2 = X1 - X2;
   int distY1Y2 = Y1 - Y2;
   int sumSquare = distX1X2 * distX1X2 + distY1Y2 * distY1Y2;
   double result = Math.Sqrt(sumSquare);
   return result;
}


Console.Write("Введите координаты ПЕРВОЙ точки. ");
Console.WriteLine("Координата Х: ");
int coordX1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Координата Y: ");
int coordY1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите координаты ВТОРОЙ точки. ");
Console.WriteLine("Координата Х: ");
int coordX2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Координата Y: ");
int coordY2 = Convert.ToInt32(Console.ReadLine());

double distanse = Distance(coordX1, coordY1, coordX2, coordY2);
double distanseRound = Math.Round(distanse, 2, MidpointRounding.ToZero);
Console.WriteLine(distanseRound);