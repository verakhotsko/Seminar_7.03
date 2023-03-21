// Пр-ма, которая задаёт массив из N элементов,
// заполненный случайными числами в заданном диапазоне и 
// выводит его на экран.

// метод заполняющий массив:
void FillArray(int [] num, int num1, int num2)
{
   int length = num.Length;
   for(int i = 0; i < length; i++)
   {
   num[i] = new Random().Next(num1, num2 + 1);
   }
}
// метод выводящий массив:
void PrintArray(int [] numb)
{
    int dist = numb.Length;
    for(int j = 0; j < dist; j++)
    {
        Console.Write(numb[j] + " ");
    }
}
// сама программа:
Console.Write("Введите минимальное число желаемого диапазона массива: ");
int minRange = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите максимальное число желаемого диапазона массива: ");
int maxRange = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество элементов желаемого массива: ");
int [] array = new int [Convert.ToInt32(Console.ReadLine())];
FillArray(array, minRange, maxRange);
PrintArray(array);
