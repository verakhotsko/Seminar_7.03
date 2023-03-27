// Пр-ма, кщторая создаёт копию заданного массива
// с помощью поэлементного копирования.

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

int[] CopyArray(int[]arr)
{
    int[] copyArr = new int[arr.Length];
    for (int i = 0; i < arr.Length; i++)
    {
        copyArr[i] = arr[i];
    }
    return copyArr;
}

int[] array = CreateArray(10, 2, 12);
PrintArray(array);
Console.WriteLine();
int[] copyArray = CopyArray(array);
//copyArray[0] = 8;
PrintArray(copyArray);
Console.WriteLine();
bool result = Equal(array, copyArray);
Console.WriteLine(result ? "Равны" : "Не равны");

// метод, проверяющий равны ли массивы поэлементно

bool Equal(int[]arr1, int[]arr2)
{
    if(arr1.Length != arr2.Length)
    {
        return false;
    }

    for (int i = 0; i < arr1.Length; i++)
    {
        if (arr1[i] != arr2[i])
        {
            return false;
        }
    }
    return true;
}