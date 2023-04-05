// Задайте двумерный массив. 
// Напишите программу, которая упорядочит 
// по убыванию элементы каждой строки двумерного массива.
// Например:
// 1 4 7 2      7 4 2 1
// 5 9 2 3      9 5 3 2
// 8 4 2 4      8 4 4 2

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

void SortStringMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(1); k++)
            {
                if(matrix[i, j] > matrix[i, k])
                {
                int temp = 0;
                temp = matrix[i,  j];
                matrix[i, j] = matrix[i, k];
                matrix[i, k] = temp;
                }
            }
            
        }
    }
}

int[,] array2d = CreateMatrix(3, 4, -10,10);
PrintMatrix(array2d);
Console.WriteLine();
SortStringMatrix(array2d);
PrintMatrix(array2d);

