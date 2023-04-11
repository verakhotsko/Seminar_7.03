// Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.

// метод проверки чисел на положительность:

bool CheckPositivNum(int num)
{
    return num >= 0; 
}

int Ackerman(int num1, int num2)
{
    while (num1 != 0)
    {
        if (num2 == 0) num2 = 1;
        else num2 = Ackerman(num1, num2 - 1);
        num1 = num1 - 1;
    }
    return num2 + 1;
}

Console.Write("Введите положительное число m: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите положительное число n: ");
int number2 = Convert.ToInt32(Console.ReadLine());


if(CheckPositivNum(number1) && CheckPositivNum(number2))
{
    int result = Ackerman(number1, number2);
    Console.WriteLine($"m = {number1}; n = {number2} -> A(m,n) -> {result}");
}
else 
{
    Console.WriteLine("Введенные вами числа не положительные. Повторите ввод.");
}