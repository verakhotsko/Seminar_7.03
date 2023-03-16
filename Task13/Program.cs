// Пр-ма, которая выводит третью цифру числа или
// сообщает, что третьей цифры нет.

// Метод
//int TrirdDigital(int num)
//{
//    int thirdNum = num % 10;
//    if (num > 99 && num < 999)
//    Console.WriteLine(thirdNum);
//    else Console.WriteLine("В этом числе нет третьей цифры.");
//    
//    return thirdNum;
//}
//Программ
//Console.WriteLine("Введите число в диапазоне [10; 999]");
//int number = Convert.ToInt32(Console.ReadLine());
//int result = number % 10;
//if (number > 99) Console.WriteLine(result);
//else Console.WriteLine("В этом числе нет третьей цифры.");
//Console.WriteLine(TrirdDigital(number));

// Решение от GeekBrains:
int Prompt(string message)            //метод конвертирующий текст в число
{
    Console.Write(message);
    string value = Console.ReadLine();
    int result = Convert.ToInt32(value);
    return result;
}

int GetThirdRank(int number)        // метод выводящий третью цифру числа
{
    while (number > 999)
    {
        number /= 10;
    }
    return number % 10;
}

bool ValidateNumber (int number)    // метод возвращающий да/нет
{
    if (number < 100)
    {
        Console.WriteLine("Третьей цифры нет");
        return false;
    }
    return true;
}

int number = Prompt("Введите число ");  // программа: число взять при помощи метода конвертации сообщений
if (ValidateNumber(number))             // если выполняется булевое условие, то 
{
    Console.WriteLine(GetThirdRank(number)); // печатай нахождение третьей цифры
}