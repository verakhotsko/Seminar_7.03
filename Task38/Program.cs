// Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементом массива.(max-min)

// метод, заполняющий массив:

double[] CreateDoubleArray(int size, int min, int max)
{
    double[] arr = new double[size];
    Random rnd = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.NextDouble() * (max - min) + min;
        arr[i] = Math.Round(arr[i], 2, MidpointRounding.ToZero);
    }
    return arr;
}

// метод печатающий массив:

void PrintArray(double[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if(i < arr.Length - 1) Console.Write($"{arr[i]}; ");
        else Console.Write($"{arr[i]}");
    }
    Console.Write("]");
}

// метод, находящий максимальное число 

double MaxDoublNum(double[] arr)
{
    double maxNum = arr[0];
    for (int i = 1; i < arr.Length; i++)
    {
       if(arr[i] > maxNum)
       {
        maxNum = arr[i];
       } 
    }
    return maxNum;
}

// метод, находящий минимальное число 

double MinDoublNum(double[] arr)
{
    double minNum = arr[0];
    for (int i = 1; i < arr.Length; i++)
    {
       if(arr[i] < minNum)
       {
        minNum = arr[i];
       } 
    }
    return minNum;
}

// сама программа:
double[] array = CreateDoubleArray(9, 1, 10);                            
PrintArray(array);
double difference = MaxDoublNum(array) - MinDoublNum(array);
double diffRound = Math.Round(difference, 2, MidpointRounding.ToZero);
Console.WriteLine();
Console.WriteLine($"Разница между максимальным и минимальным число массива: {diffRound}");