// Пр-ма, которая принимает на вход трёхзначное число,
// а на выходе показывает последнюю цифру этого числа.

Console.Write("Введите трёхзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number >= 100 && number <= 999) // вводим условие для точного введения трёхзначного числа
{
    int lastNumber = number % 10;
    Console.WriteLine(lastNumber);
}
else
{
    Console.WriteLine("Трёхзначное число это три цифры подряд. Ввведите правильное число.");
}