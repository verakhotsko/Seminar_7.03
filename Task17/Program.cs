// Пр-ма, которая на вход принимает координаты точки (х и у),
// причём х!=0 и у!=0
// и выдаёт номер четверти плоскости, в которой находится эта точка.

Console.WriteLine("Введите координаты точки");
Console.Write("X: ");
int xCoordinate = Convert.ToInt32(Console.ReadLine());
Console.Write("Y: ");
int yCoordinate = Convert.ToInt32(Console.ReadLine());

int Quarter(int x, int y)
{
    if (x > 0 && y > 0) return 1;
    if (x < 0 && y > 0) return 2;
    if (x < 0 && y < 0) return 3;
    if (x > 0 && y < 0) return 4;
    return 0;
}

int quarter = Quarter(xCoordinate, yCoordinate);
string result = quarter > 0 ? $"Указанные координаты соответствуют четверти {quarter}."
: "Введены некорректные координаты";
Console.WriteLine(result);