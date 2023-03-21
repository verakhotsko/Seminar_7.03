// Пр-ма, которая определяет, присутствует ли заданное число 
// в заданном массиве.

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

// метод, определяющий присутствие заданного числа:

bool SearchNum(int num, int[] arr)
{
    int index = 0;
    while (index < arr.Length)
    {
        if (arr[index] == num)
        {
            return true;
        }
        index++;
    }
    return false;
}

Console.Write("Введите минимальное число диапазона массива: ");
int minRange = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите максимальное число диапазона массива: ");
int maxRange = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите необходимое количество элементов в массиве: ");
int count = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число, которое необходимо найти в массиве: ");
int number = Convert.ToInt32(Console.ReadLine());
int[] array = CreateArray(count, minRange, maxRange);
PrintArray(array);
Console.WriteLine();
bool result = SearchNum(number, array);
Console.WriteLine(result ? "Присутствует" : "НЕ присутствует");