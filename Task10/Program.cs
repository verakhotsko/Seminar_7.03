// Пр- ма, которая на вход принимает трёхзначное число и 
// на выход показывает вторую цифру этого числа.

//Метод
//int SecondDig(int num)
//{
//    int num1 = num % 100;
//    int num2 = num1 / 10;
//    return num2;
//}
// Программа
//Console.WriteLine("Введите трёхзначное число: ");
//int number = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine($"Вторая цифра этого числа: {SecondDig(number)}");

// Решение от GeekBrains:
int Prompt(string message)
{
    System.Console.Write(message);
    string value = Console.ReadLine();
    int result = Convert.ToInt32(value);
    return result;
}

int number = Prompt("Введите трёхзначное число");
if (number < 100 || number >= 1000)
{
    Console.WriteLine("Вы ввели не трёхзначное число. Введите другое.");
    return;
}
Console.WriteLine($"Введенное число {number}");
int secondRank = number / 10 % 10;
Console.WriteLine($"Вторая цифра {secondRank}");