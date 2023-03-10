// Пр-ма, принмает на вход 3 числа, а
// на выход выдает максимальное из этих чисел.

Console.Write("Введите первое целое число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе целое число: ");
int number2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите третье целое число: ");
int number3 = Convert.ToInt32(Console.ReadLine());

if (number2 > number1)
{
    number1 = number2;
}
if (number3 > number1)
{
    number1 = number3;
}
Console.WriteLine($"Максимальное число: {number1}");