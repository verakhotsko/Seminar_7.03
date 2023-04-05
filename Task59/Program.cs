// Задайте двумерный массив из целых чисел.
// Пр-ма, кот. удалит строку и столбец, 
// на пересечении которых расположен наименьший элемент масссива.

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

//int[] CoordinateMinimumValue(int[,] matrix)
//{
//    int minIndexRow = 0;
//    int minIndexColumn = 0;
//    for (int i = 0; i < matrix.GetLength(0); i++)
//    {
//        for (int j = 0; j < matrix.GetLength(1); j++)
//        {
//            if (matrix[i, j] < matrix[minIndexRow, minIndexColumn])
//            {
//                minIndexRow = i;
//                minIndexColumn = j;
//            }
//        }
//    }
//    return new int[] { minIndexRow, minIndexColumn };
//}
(int, int) FindMinElement(int[,] matrix)
{
    int minI = 0;
    int minJ = 0;
    int minValue = matrix[0, 0];

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            int element = matrix[i, j];

            if (element < minValue)
            {
                minI = i;
                minJ = j;
                minValue = element;
            }
        }
    }
    return (minI, minJ);
}

int[,] DropColumnAndRow(int minI, int minJ, int[,] matrix)
{
    int rows = matrix.GetLength(0);
    int columns = matrix.GetLength(1);

    int[,] newMatrix = new int[rows - 1, columns - 1];

    for (int i = 0, newRow = 0; i < rows; i++)
    {
        if (i == minI) continue;

        for (int j = 0, newColumn = 0; j < columns; j++)
        {
            if (j == minJ) continue;

            newMatrix[newRow, newColumn] = matrix[i, j];
            newColumn++;
        }
        newRow++;
    }
    return newMatrix;
}



int[,] array2d = CreateMatrix(3, 4, 1, 10);
PrintMatrix(array2d);
Console.WriteLine();
(int minI, int minJ) = FindMinElement(array2d);
int[,] newMatrix = DropColumnAndRow(minI, minJ, array2d);
PrintMatrix(newMatrix);