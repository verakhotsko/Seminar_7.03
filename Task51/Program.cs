// Задайте двумерный массив.
// Найдите сумму элементов, на главной диагонали
// (с индексами (0,0); (1,1)) и т.д.

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

int SumNumbersDiagonal(int[,] matrix)
{
    int sumMatrix = 0;
    for (int i = 0; i < matrix.GetLength(0); i++) //для строк
    {
        for (int j = 0; j < matrix.GetLength(1); j++) // для столбцов
        {
          if(j == i) sumMatrix = sumMatrix + matrix[i, j];
        }
    }
    return sumMatrix;
}

int[,] array2d = CreateMatrix(3, 7, 1 ,10);
PrintMatrix(array2d);
Console.WriteLine();
int sumNumDiagonal = SumNumbersDiagonal(array2d);
Console.WriteLine(sumNumDiagonal);