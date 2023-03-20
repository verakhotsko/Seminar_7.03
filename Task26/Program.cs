// Пр-ма, которая принимает на вход число и
// выдает количество цифр в числе.

int CountDigit(int num)
{
    int count = 0;
    while (num != 0)
    {
        num = num / 10;
        count ++;
    }
    return count;
}

Console.WriteLine("Введите целое число: ");
int number = Convert.ToInt32(Console.ReadLine());
int countDigit = CountDigit(number);
Console.WriteLine($"Количество цифр в числе {number}: {countDigit}.");