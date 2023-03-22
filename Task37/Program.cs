// Найдите произведение пар чисел в одномероном массиве.
// Парой считаем первый и последний элемент, второй и предпоследний.
// Результат запишите в новом массиве.

// метод, заполняющий массив:

internal class Program
{
    private static void Main(string[] args)
    {
        int[] CreateArray(int size, int min, int max)
        {
            int[] arr = new int[size];
            Random rnd = new Random();
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rnd.Next(min, max + 1);
            }
            return arr;
        }

        // метод печатающий массив:

        void PrintArray(int[] arr)
        {
            Console.Write("[");
            for (int i = 0; i < arr.Length; i++)
            {
                if (i < arr.Length - 1) Console.Write($"{arr[i]}, ");
                else Console.Write($"{arr[i]}");
            }
            Console.Write("]");
        }

        // метод, перемножающий элементы массива по заданным парам:

        int[] ProductArray(int[] arr)
        {
            int size = arr.Length;                // задаём длину будущего массива
            if (arr.Length % 2 > 0)
            {
                size = arr.Length / 2 + 1;         // если нечётный
            }
            else
            {
                size = arr.Length / 2;           // если чётный
            }
            int[] newArray = new int[size];      // задаём будущий массив

            for (int i = 0; i < arr.Length / 2; i++)
            {
                int product = arr[i] * arr[arr.Length -1 - i];
                newArray[i] = product;
            }

            int medianNum = arr.Length / 2;        // условие для нечётного количества чисел в массиве
            if (arr.Length % 2 > 0)
            {
                newArray[size - 1] = arr[medianNum]; // срединное число перенести в коней массива
            }
            return newArray;
        }

        int[] array = CreateArray(7, 1, 10);
        PrintArray(array);
        Console.WriteLine();
        int[] productArray = ProductArray(array);
        PrintArray(productArray);
    }
}