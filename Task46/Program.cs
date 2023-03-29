// Задайте двумерный массив размером м*н,
// заполненный случайными числами.


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

int[,] array2d = CreateMatrix(3, 4, 1 ,100);
PrintMatrix(array2d);