// Пр-ма, которая принимает на вход три числа и проверяет,
// может ли существовать треугольник со сторoнами такой длины.

bool Triangle(int a, int b, int c)
{
    if(a < b + c && b < a + c && c < b + a) return true;
    else return false;
}

Console.WriteLine("Введите первое положительное число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе положительное число: ");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третье положительное число: ");
int num3 = Convert.ToInt32(Console.ReadLine());
bool result = Triangle(num1, num2, num3);
Console.WriteLine(result ? "Такой треугольник существует" : "Такого треугольника не существует");