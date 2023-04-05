// Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку 
// с наименьшей суммой элементов
// и выдаёт номер этой строки. 

int[,] CreateMatrix(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++) //для строк
    {
        for (int j = 0; j < matrix.GetLength(1); j++) // для столбцов
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j],4} ");
        }
        Console.WriteLine("|");
    }
}

void PrintArray(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if(i < arr.Length - 1) Console.Write($"{arr[i]}; ");
        else Console.Write($"{arr[i]}");
    }
    Console.Write("]");
}

// метод, возвращающий массив из построчных сумм таблицы

int[] SumStringsMatrix(int[,] matrix)
{
    int[] sumStringArr = new int[matrix.GetLength(0)];
    int sumString = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            sumString = sumString + matrix[i, j];
        }
        sumStringArr[i] = sumString;
        sumString = 0;
    }
    return sumStringArr;
}

// метод, возвращающий порядковый номер минимального элемента

int MinElementArray(int[] arr)
{
    int minElement = arr[0];
    int numberElem = 0;
    for (int i = 1; i < arr.Length; i++)
    {
       if(arr[i] < minElement)
       {
        minElement = arr[i];
        numberElem = i;
       }
    }   
    return numberElem;
}

int[,] array2d = CreateMatrix(5, 3, 0, 10);
PrintMatrix(array2d);
Console.WriteLine();
int[] arraySum = SumStringsMatrix(array2d);
PrintArray(arraySum);
Console.WriteLine();
int result = MinElementArray(arraySum);
Console.WriteLine($"С наименьшей суммой элементов: {result + 1} - строка.");