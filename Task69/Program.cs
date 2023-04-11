// Пр-ма, которая на вход принимает два числа,
// а на выходе возводит первое число в целую степень второго числа.

int DedreeNum(int num1, int num2)
{
    if (num2 == 0) return 1;
    else return num1 * DedreeNum(num1, num2 -1);
}

Console.Write("Введите первое целое положительное число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе целое положительное число: ");
int number2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(DedreeNum(number1, number2));