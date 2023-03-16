// Пр-ма, которая по заданному номеру четверти,
// показывает диапазон возможных координат точек в этой четверти (х и у).

string Coordinate(string quater) // string X, string Y
{
    if (quater == "1") return "X > 0, Y > 0";
    if (quater == "2") return "X < 0, Y > 0";
    if (quater == "3") return "X < 0, Y < 0";
    if (quater == "4") return "X > 0, Y < 0";
    return "Такой четверти нет.";
}

Console.Write("Введите номер четверти ");
string number = Console.ReadLine();
string coordinate = Coordinate(number);
Console.WriteLine(coordinate);