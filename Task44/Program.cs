// Не используя рекурсию, выведите первые N чисел
// Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
// если N = 5 -> 01123

int[] FibonachiArr(int num)
{
   int[] arr = new int[num];
   arr[0] = 0;
   arr[1] = 1;
   for (int i = 2; i < num; i++)
   {
      arr[i] = arr[i - 2] + arr[i - 1];
   } 
  return arr;
}

void PrintArray(int[]arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if(i < arr.Length - 1) Console.Write($"{arr[i]}, ");
        else Console.Write($"{arr[i]}");
    }
    Console.Write("]");
}
Console.Write("Введите целое положительное число от 2 и больше: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number < 2)
{
    Console.WriteLine("Невозможно создать число Фибоначчи. Введите другое.");
}
else
{
    int[] array = FibonachiArr(number);
    PrintArray(array);
}

