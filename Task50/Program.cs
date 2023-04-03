// Пр-ма, которая на вход принмает позиции элемента
// в двумерном массиве, и возвращает значения этого элемента
// или же указывает, что такого элемента нет.

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

// метод вывода элемента в двумерном массиве с заданной позицией 

void PrintPositionElement(int[,] matrix, int num1, int num2)
{
    if(num1 <= matrix.GetLength(0) 
       && num2 <= matrix.GetLength(1)
       && num1 >= 0 
       && num2 >= 0)
    Console.WriteLine(matrix[num1, num2]);
    else Console.WriteLine("Такого элемента нет.");
}

int[,] array2d = CreateMatrix(4, 4, 1 ,10);
PrintMatrix(array2d);
Console.Write("Введите индекс строки: ");
int row = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите индекс столбца: ");
int column = Convert.ToInt32(Console.ReadLine());
PrintPositionElement(array2d, row, column);

