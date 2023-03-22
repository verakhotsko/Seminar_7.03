// Задайте одномерный массив из 123 случайных чисел.
// Найдите количество элементов массива, значения которых
// лежат в отрезке [10, 99].(Найти количество двузначных чисел).

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

// метод печатающий массив:

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

// метод, возвращающий количество двухзначных чисел в массиве:

int CountTwoNumbers(int[]arr, int min, int max)
{
    int count = 0;
    for (int j = 0; j < arr.Length; j++)    
    {
        if(arr[j] >= min && arr[j] < max)
        {
            count += 1;
        }
    }
    return count;
}

int[] array = CreateArray(123, 1, 200);                            
PrintArray(array);
Console.WriteLine();
Console.WriteLine($"Количество цифр в заданном диапазоне: {CountTwoNumbers(array, 10, 99)}");