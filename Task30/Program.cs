// Пр-ма, которая выводит массив из 8 элементов,
// заполненный нулями и единицами в случайном порядке.


void FillArray(int[]num)
{
    int length = num.Length;
    for(int i = 0; i < length; i ++)
    {
        num[i] = new Random().Next(0, 2);
    }
}

void PrintArray(int[]numb)
{
    int count = numb.Length;
    for(int j = 0; j < count; j ++)
    {
        Console.Write(numb[j] + " ");
    }
}

int []array = new int [8];
FillArray(array);
PrintArray(array);