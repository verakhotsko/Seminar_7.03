// Задайте двумерный массив.
// Пр-ма, которая меняет местами первую и последнюю строку массива.

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

// метод, меняющий элементы из первой строки на элементы последней строки.
void ReplacementRow(int[,] matrix)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        int temp = matrix[matrix.GetLength(0) - 1, j];    // временная переменная для обмена элементов
        matrix[matrix.GetLength(0) - 1, j] = matrix[0, j];
        matrix[0, j] = temp;
    }
}

int[,] array2d = CreateMatrix(3, 4, 1 ,10);
PrintMatrix(array2d);
Console.WriteLine();
ReplacementRow(array2d);
PrintMatrix(array2d);

