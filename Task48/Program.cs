// Задайте двумерный массив размера м*н,
// каждый элемент в массиве находится по формуле: Амн = м + н.
// Выведите полученный массив на экран.
// м = 3, н = 4

int[,] CreateMatrixSumIndex(int rows, int columns) 
{
    int[,] matrix = new int[rows, columns];
    for (int i = 0; i < matrix.GetLength(0); i++) 
    {
        for (int j = 0; j < matrix.GetLength(1); j++) // для столбцов
        {
            matrix[i, j] = i + j;
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

int[,] array2d = CreateMatrixSumIndex(3, 4);
PrintMatrix(array2d);