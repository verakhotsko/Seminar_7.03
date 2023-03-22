// Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.

// метод, заполняющий массив:

int[] CreateArray(int size, int min, int max)
{
    int[] arr = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(min, max + 1);
    }
    return arr;
}

// метод, выводящий массив:

void PrintArray(int[]arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if(i < arr.Length - 1) Console.Write($"{arr[i]}, ");
        else Console.Write($"{arr[i]}");
    }
    Console.Write("]");
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

int[] array = CreateArray(12, -8, 10);                                           //Console.Write("Введите минимальное число диапазона массива: ");
PrintArray(array);                                                               //int minRange = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();                                                             //Console.Write("Введите максимальное число диапазона массива: ");
Console.WriteLine($"Сумма чисел с нечётными индексами:{SumNotEvenNum(array)}."); //int maxRange = Convert.ToInt32(Console.ReadLine());
                                                                                 //Console.Write("Введите необходимое количество элементов в массиве: ");
                                                                                 //int count = Convert.ToInt32(Console.ReadLine());
                                                                                 //int []array = new int [count]; 


