// Пр-ма, которая на вход принимает число (N),
// а на выход выдает таблицу квадратов чисел.

void TabSquare(int num)
{
int count = 0;

    while (count <= num)
    {
       int square = count * count;
       Console.WriteLine($"{count, 3}  ->  {square, 5}"); // выравнивание по длине строки
       count ++;
    }
}

Console.WriteLine("Введите целое число: ");
int number = Convert.ToInt32(Console.ReadLine());
TabSquare(number);                  // так вызывается метод Void