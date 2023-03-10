// Пр-ма, которая на входе принимает целое положительное число (N),
// а на выходе показывает все целые числа в промежутке от -N до N.

Console.WriteLine("Введите целое положительное число: ");
int number = Convert.ToInt32(Console.ReadLine());
int count = -number; // счётчик
while(count <= number)
{
    Console.Write($"{count}, "); // начнёт с отрицательного числа
    count++;
}
