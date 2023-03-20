// Пр-ма, которая на вход принимает число (А), а 
// на выход выдаёт сумму чисел от 1 до А.

int Sumnumbers(int num)
{
    int sum = 0;
    for(int i = 1; i <= num; i++)
    {
        sum = sum + i; // sum += i;
    }
    return sum;
}

Console.WriteLine("Введите целое положительное число: ");
int number = Convert.ToInt32(Console.ReadLine());
int sumNubers = Sumnumbers(number);
Console.WriteLine($"Сумма чисел от 1 до {number} равна: {sumNubers}");