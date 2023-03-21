// Задайте массив из 12 элементов, 
// заполненный случайными числами из промежутка [-9, 9].
// Найдите сумму отрицательных и положительных элементов массива (каждую отдельно).

// метод на создание и заполнения массива:

int[] CreateArrayRndInt(int size, int min, int max)
{
    int[] arr = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(min, max + 1);
    }
    return arr;
}

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

// метод возвращающий сумму отрицательных чисел:

int SumNegativeElements(int [] arr)
{
    int sum = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if(arr[i] < 0) sum += arr[i];
    }
    return sum;
}

// мметод, возвращающий сумму положительных чисел:

int SumPositiveElements(int [] arr)
{
    int sum = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if(arr[i] > 0) sum += arr[i];
    }
    return sum;
}

// сама программа:

int[] array = CreateArrayRndInt(12, -9, 9);
PrintArray(array);
Console.WriteLine();
int sumNegativeElem = SumNegativeElements(array);
int sumPositiveElem = SumPositiveElements(array);
Console.WriteLine($"Сумма отрицательных элементов массива равна {sumNegativeElem}");
Console.WriteLine($"Сумма положительных элементов массива равна {sumPositiveElem}");