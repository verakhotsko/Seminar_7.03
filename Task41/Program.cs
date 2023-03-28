// Пользователь вводит с клавиатуры М чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.

// метод, выводящий сообщение пользователя
int PrintMessage(string message)
{
    Console.Write(message);
    string value = Console.ReadLine();
    int result = Convert.ToInt32(value);
    return result;
}

// метод, ввода массива пользователем

int[] InputArray(int length)
{
    int[] arr = new int[length]; // создаём массив с длиной, которую введет пользователь
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = PrintMessage($"Введите {i + 1}-й элемент: "); // сообщние для последовательного ввода элементов
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

// метод, подсчитывающий количество положительных чисел

int CountPositiveNum(int[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0)
        {
            count++;
        }
    }
    return count;
}

int length = PrintMessage("Введите количество чисел, которые хотите обработать: ");
int[] array;
array = InputArray(length);
PrintArray(array);
Console.WriteLine();
Console.WriteLine($"Количество положительных чисел: {CountPositiveNum(array)}");

