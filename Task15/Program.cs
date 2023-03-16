// Пр-ма, которая на вход принимает цифру, обозначающую день недели
// и на выход проверяет, является ли эта цифра выходным.

Console.WriteLine("Введите цифру от 1 до 7, включительно: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number > 5)Console.WriteLine("да, выходной");
else Console.WriteLine("нет, рабочий");

