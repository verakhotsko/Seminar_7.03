// Пр-ма, которая меняет положительные элементы массива
// на соответствующие отрицательные и наоборот.

// метод создающий и заполяющий массив:

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

// метод меняющий знак в элементе массива

void Replacement(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i]*= -1;
        Console.Write($"{arr[i]}, ");
    }
    Console.Write("]");
}

Console.Write("Введите отрицательное число диапазона массива: ");
int minRange = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите положительное число диапазона массива: ");
int maxRange = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите необходимое количество элементов в массиве: ");
int count = Convert.ToInt32(Console.ReadLine());
int[] array = CreateArray(count, minRange, maxRange);
PrintArray(array);
Console.WriteLine();
Replacement(array);