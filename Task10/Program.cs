// Пр- ма, которая на вход принимает трёхзначное число и 
// на выход показывает вторую цифру этого числа.

//Метод
int SecondDig(int num)
{
    int num1 = num % 100;
    int num2 = num1 / 10;
    return num2;
}
// Программа
Console.WriteLine("Введите трёхзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Вторая цифра этого числа: {SecondDig(number)}");