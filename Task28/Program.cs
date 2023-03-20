// Программа, которая на вход принимает число N, а 
// на выход выдаёт произведение чисел от 1 до N.

int Factorial(int num)
{
    int fact = 1;
    for(int i = 2; i <= num; i ++)
    {
        checked                    // на переполнение типа int
        {
            fact = fact * i;
        }
    }
    return fact;
}

Console.WriteLine("Введите целое положительное число: ");
int number = Convert.ToInt32(Console.ReadLine());
int factorial = Factorial(number);
Console.WriteLine($"Произведение чисел от 1 до {number} равно {factorial}.");