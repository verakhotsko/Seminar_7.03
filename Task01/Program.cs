// Пр-ма, которая на вход принимает 2 числа и
// проверяет, является ли первое квадратом второго.

internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Введите первое целое число: "); // взаимодействие с пользователем
        int number1 = Convert.ToInt32(Console.ReadLine()); // перевод строки в целочисленный тип

        Console.Write("Введите второе целое число: ");
        int number2 = Convert.ToInt32(Console.ReadLine());
        int square = number2 * number2; // дополнительная переменная для действия квадрата
        if (number1 == square) // условие ветвление
        {
            Console.WriteLine("Первое число ЯВЛЯЕТСЯ квадратом второго");
        }
        else
        {
            Console.WriteLine("Первое число НЕ ЯВЛЯЕТСЯ квадратом второго");
        }
    }
}