// Задайте две матрицы. 
// Напишите программу, которая будет находить произведение двух матриц.

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

// метод, перемножающий матрицы
int[,] MultiplicationMatrix(int[,] matrix1, int[,] matrix2)
{
    int[,] multiplMatrix = new int[matrix1.GetLength(0), matrix2.GetLength(1)];

    for (int i = 0; i < matrix1.GetLength(0); i++)
    {
        for (int j = 0; j < matrix2.GetLength(1); j++)
        {
            for (int k = 0; k < matrix2.GetLength(1); k++)
            {
                multiplMatrix[i, j] += matrix1[i, k] * matrix2[k, j];
            }
        }
    }
    return multiplMatrix;
}

// метод, проверяющий, что две матрицы равны по размеру

bool SizeTwoMatrix(int[,] matrix1, int[,] matrix2)
{
    if (matrix1.GetLength(1) == matrix2.GetLength(0))
    {
        return true;
    }
    else
    {
        return false;
    }
}

int[,] array2d1 = CreateMatrix(3, 2, 1, 10);
PrintMatrix(array2d1);
Console.WriteLine();
int[,] array2d2 = CreateMatrix(3, 3, 1, 10);
PrintMatrix(array2d2);
Console.WriteLine();
bool result = SizeTwoMatrix(array2d1, array2d2);
if (result)
{
    int[,] multiplArray2d = MultiplicationMatrix(array2d1, array2d2);

    PrintMatrix(multiplArray2d);
}
else Console.WriteLine("Данные матрицы невозможно перемножить.");