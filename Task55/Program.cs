// Задайте двумерный массив.
// Пр-ма, кот. заменяет строки на столбцы (квадратная матрица).
// Если это невозможно (прямоугольная матрица), то сообщает пользователю.

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

// метод, меняющий строки на столбцы в квадратной матрице

void ReplaceRowColumn(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < i; j++)
        {
            int tempIndex = matrix[i, j];
            matrix[i, j] = matrix[j, i];
            matrix[j, i] = tempIndex;
        }
    }
}

bool SquareOrrectangle(int[,] matrix)
{
    return (matrix.GetLength(0) == matrix.GetLength(1));
}


int[,] array2d = CreateMatrix(4, 3, 1, 10);
PrintMatrix(array2d);
if (SquareOrrectangle(array2d))
{
    Console.WriteLine();
    ReplaceRowColumn(array2d);
    PrintMatrix(array2d);
}
else
{
    Console.WriteLine("Число строк не равно столбцам.");
}