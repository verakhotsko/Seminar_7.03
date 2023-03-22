// Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.

// метод, заполняющий массив положительными трёхзначными числами:
int[] CreateArray(int size, int min, int max)
{
    int[] arr = new int[size];
    Random rnd = new Random();
    if (min >= 100 && max < 1000)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = rnd.Next(min, max + 1);
        }
    }
    return arr;
}

// метод выводящий массив:

void PrintArray(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if(i < arr.Length - 1) Console.Write($"{arr[i]}, ");
        else Console.Write($"{arr[i]}");
    }
    Console.Write("]");
}

// метод показывающий количество чётных чисел в массиве:

int AmountEvenNum(int[] num)
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
int[]array = CreateArray(20, 102, 875);                                          //Console.Write("Введите минимальное число диапазона массива: ");
PrintArray(array);                                                               //int minRange = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();                                                             //Console.Write("Введите максимальное число диапазона массива: ");
Console.WriteLine($"Количество чётных чисел в массиве: {AmountEvenNum(array)}"); //int maxRange = Convert.ToInt32(Console.ReadLine());
                                                                                 //Console.Write("Введите необходимое количество элементов в массиве: ");
                                                                                 //int count = Convert.ToInt32(Console.ReadLine());
                                                                                 //int[] array = CreateArray(count, minRange, maxRange);