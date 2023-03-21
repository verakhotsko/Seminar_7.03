// Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.

// метод, заполняющий массив:

void FillArray(int[]num, int num1, int num2)
{
    int length = num.Length;
    for(int i = 0; i < length; i ++)
    {
        num[i] = new Random().Next(num1, num2);
    }
}

// метод, выводящий массив:

void PrintArray(int[]numb)
{
    int count = numb.Length;
    for(int j = 0; j < count; j ++)
    {
        Console.Write(numb[j] + " ");
    }
}

// метод, находящий сумму элементов на нечётной позиции:

int SumNotEvenNum(int[]number)
{
    int dist = number.Length;
    int index = 1;
    int sum = 0;
    while(index < dist)
    {
        sum = sum + number[index];
        index += 2;
    }
    return sum;
}

// сама программа:

Console.Write("Введите минимальное число диапазона массива: ");
int minRange = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите максимальное число диапазона массива: ");
int maxRange = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите необходимое количество элементов в массиве: ");
int count = Convert.ToInt32(Console.ReadLine());
int []array = new int [count];
FillArray(array, minRange, maxRange);
PrintArray(array);
Console.WriteLine($"Сумма чисел, стоящих на нечётных позициях равна {SumNotEvenNum(array)}.");