// Напишите программу, которая 
// 1. на вход принимает число и 
// 2. выдает его квадрат.

// string input = Console.ReadLine(); // присваиваем строке нужную команду
// int number = Convert.ToInt32(input); // конвертируем строку в целочисленный тип
Console.Write("Введите целое число: "); // взаимодействие с пользователем
int number = Convert.ToInt32(Console.ReadLine()); // в одну строку
int square = number * number; // само действие
Console.WriteLine($"Квадрат числа {number} = {square}"); //интерполяция строки в действия