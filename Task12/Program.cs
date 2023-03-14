// Пр-ма, которая на вход принимает два числа и 
// выводит, является ли первое число кратное второму.
// Если не является, то выводит остаток от деления.


// Метод:
int Remainder(int num1, int num2)
{
 int remNum = num1 % num2;
 return remNum;
}
// Программа:
Console.WriteLine("Введите первое целое число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе целое число: ");
int number2 = Convert.ToInt32(Console.ReadLine());

if (Remainder(number1, number2) == 0) Console.WriteLine($"Первое число КРАТНО второму.");
else Console.WriteLine($"Не кратно. Отстаток от деления: {Remainder(number1, number2)}");
