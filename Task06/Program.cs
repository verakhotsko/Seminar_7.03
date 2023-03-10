// Пр-ма, котрая на вход принимает число, а 
// на выход выдает - является ли число четным.

Console.Write("Введите целое число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number % 2 == 0)
{
    Console.WriteLine("Является чётным");
}
else
{
    Console.WriteLine("Не является чётным");
}
