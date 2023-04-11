// Задайте значения M и N. 
// Напишите программу, которая найдёт сумму натуральных элементов 
// в промежутке от M до N.

// метод проверки числа на натуральность:

bool CheckNaturalNum(int num)
{
    return num >= 1;
}

int SumNumbers(int num1, int num2)
{
    if (num1 == num2) return num2;
    {
        if (num1 < num2) 
        return num1 + SumNumbers(num1 + 1, num2);
        else 
        return num1 + SumNumbers(num1 - 1, num2);
    }
}

Console.Write("Введите первое натуральное число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе натуральное число: ");
int number2 = Convert.ToInt32(Console.ReadLine());

int sumNumbers = SumNumbers(number1, number2);

if (CheckNaturalNum(number1) && CheckNaturalNum(number2))
{
    Console.WriteLine($"Сумма чисел в промежутке от {number1} до {number2} равна {sumNumbers}");
}
else
{
    Console.WriteLine("Введённые вами числа не натуральные. Повторите ввод.");
}

