// Задайте двумерный массив из целых чисел.
// Найдите среднее арифметическое элементов в каждом столбце.

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
        Console.Write($"{matrix[i, j], 4} ");
    }
    Console.WriteLine("|");
    }
}

// метод, возвращающий массив из среднего арифметического каждого столбца, заданного двумерного массива

double[] AverageNumColumns(int[,]matrix)
{
    double sumColumn = 0;                                       // сумма каждого столбца
    double averageColumn = 0;                                   // среднне арифметич. каждого столбца
    double[] averageArr = new double[matrix.GetLength(1)];      // будущий массив

    for (int j = 0; j < matrix.GetLength(1); j++) 
    {
        for (int i = 0; i < matrix.GetLength(0); i++) 
        {
            sumColumn = sumColumn + matrix[i, j];      
        }

        averageColumn = sumColumn / matrix.GetLength(0);
        averageArr[j] = Math.Round(averageColumn, 1, MidpointRounding.ToZero);
        sumColumn = 0;                                          // возвращение к другому столбцу
    }
    return averageArr;

}

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

int[,] array2d = CreateMatrix(3, 6, 1, 10);
PrintMatrix(array2d);
Console.WriteLine();
double[] arrayAverage = AverageNumColumns(array2d);
Console.Write("Среднее арифметическое каждого столбца: ");
PrintArray(arrayAverage);