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

Console.Write("Введите целое положительное число: ");
int number = Convert.ToInt32(Console.ReadLine());
NaturalNumbers(number);

