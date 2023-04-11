// Задайте значение N. 
// Напишите программу, которая выведет все натуральные числа 
// в промежутке от N до 1. Выполнить с помощью рекурсии.

void NaturalNumbers(int num)
{
    if(num == 1) 
    {
        Console.Write($"{num}");
        return;
    }
    Console.Write($"{num}, ");
    NaturalNumbers(num -1);
    
}

// метод проверки чисел на положительность

bool CheckPositivNum(int num)
{
    return num >= 0; 
}

Console.Write("Введите целое положительное число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (CheckPositivNum(number))
{
    NaturalNumbers(number);
}
else Console.WriteLine("Введенное число не положительное. Повторите ввод.");

