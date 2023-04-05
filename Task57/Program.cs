// Составить частотный словарь элементов двумерного массива.
// Он содержит информацию, сколько раз встречается элемент
// входных данных.

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

int[] MatrixToArray(int[,] matrix)
{
    int[] array = new int[matrix.Length];
    int k = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            array[k] = matrix[i, j];
            k++;
        }
    }
    return array;
}

void PrintFrequencyDictionarySortedArray(int[] array)
{
    int count = 1;
    int current = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if(array[i] == current)
        {
            count++;
        }
        else
        {
            Console.WriteLine($"{current} встречается {count} раз");
            count = 1;
            current = array[i];
        }
    }
    Console.WriteLine($"{current} встречается {count} раз");
}

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


int[,] array2d = CreateMatrix(3, 3, -10,10);
PrintMatrix(array2d);
Console.WriteLine();
int[] array1d = MatrixToArray(array2d);
Array.Sort(array1d);
PrintArray(array1d);
Console.WriteLine();
PrintFrequencyDictionarySortedArray(array1d);