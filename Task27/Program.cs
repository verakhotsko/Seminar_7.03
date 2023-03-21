// Пр-ма, которая принимает на вход число и 
// выдвёт сумму цифр в числе.

// Метод на подсчёт суммы всех цифр в числе:

int SumDigital(int num)
{
    int sum = 0;
    while (num > 0)
    {
        sum = sum + num % 10;
        num = num / 10;
    }
    return sum;
}

Console.Write("Введите целое число: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Сумма всех цифр в числе {number} равна {SumDigital(number)}.");