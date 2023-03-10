// Пр-ма, которая на вход принмает два числа,
// а на выходе выдаёт какое число большее, а какое меньшее.

Console.Write("Введите первое целое число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе целое число: ");
int number2 = Convert.ToInt32(Console.ReadLine());

if (number1 > number2)
{
    Console.WriteLine($"Максимальное число:{number1}");
    Console.WriteLine($"Минимальное число:{number2}");
}
else if (number1 == number2)
{
    Console.WriteLine("Данные числа равны. Введите разные числа.");
}
else 
{
    Console.WriteLine($"Максимальное число:{number2}");
    Console.WriteLine($"Минимальное число:{number1}");
}