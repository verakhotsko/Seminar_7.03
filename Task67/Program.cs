// Пр-ма, которая будет принимать на вход число
// и возвращать сумму его цифр.

int SumDigits(int num)
{
    if (num == 0) return 0;
    else return num % 10 + SumDigits(num / 10);
}

Console.Write("Введите целое положительное число: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(SumDigits(number));

