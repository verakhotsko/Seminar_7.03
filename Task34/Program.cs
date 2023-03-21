// Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.

// метод, заполняющий массив:

void FillArray(int[] num, int num1, int num2)
{
    int length = num.Length;
    if (num1 >= 100 && num2 < 1000)
    {
        for (int i = 0; i < length; i++)
        {
            num[i] = new Random().Next(num1, num2 + 1);
        }
    }
}

// метод выводящий массив:

void PrintArray(int [] numb)
{
    int dist = numb.Length;
    for(int j = 0; j < dist; j++)
    {
        Console.Write(numb[j] + " ");
    }
}

// метод показывающий количество чётных чисел в массиве:

int AmountEvenNum(int [] num)
{
    int length = num.Length;
    int amount = 0;
    int i = 0;
    while (i < length)
    {
        if (num[i] % 2 == 0)
        {
            amount = amount + 1;
            i++;
        }
        else
        {
            i++;
        }
    }
    return amount;
}

// сама программа:

Console.Write("Введите минимальное положительное трёхзначное число желаемого диапазона массива: ");
int minRange = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите максимальное положительное трёхзначное число желаемого диапазона массива: ");
int maxRange = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество элементов желаемого массива: ");
int[] array = new int[Convert.ToInt32(Console.ReadLine())];
FillArray(array, minRange, maxRange);
PrintArray(array);
Console.WriteLine($"Количество чётных чисел в массиве: {AmountEvenNum(array)}");