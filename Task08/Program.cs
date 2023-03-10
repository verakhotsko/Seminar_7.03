// Пр-ма, которая на вход принимает число (N), а
// на выходе показывает все четные числа от 1 до N.

Console.Write("Введите целое число: ");
int number = Convert.ToInt32(Console.ReadLine());
int count = 2;
while (count <= number)
{
    Console.Write($"{count}, ");
    count +=2;
}

