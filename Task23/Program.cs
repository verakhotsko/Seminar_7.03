// Пр-ма, которая на вход принимает число (N), а 
// на выход выдаёт таблицу кубов чисел от 1 до N.

void TabCube(int num)
{
int count = 1;

    while (count <= num)
    {
       int cube = count * count * count;
       Console.WriteLine($"{count, 3}  ->  {cube, 5}"); 
       count ++;
    }
}

Console.Write("Введите целое число: ");
int number = Convert.ToInt32(Console.ReadLine());
TabCube(number);               
