// Задайте значения M and N.
// Пр-ма, которая выведет все натуральные числа в
// промежутке от М до N.

void NaturalNumsRange(int num1, int num2)
{
  if (num1 < num2) 
  {
    Console.Write($"{num1} ");
    NaturalNumsRange(num1 + 1, num2);
  }
  else if (num1 > num2)
  {
    Console.Write($"{num1} ");
    NaturalNumsRange(num1-1, num2);
  }
  else 
  {
    Console.WriteLine(num1);
  }
}

Console.Write("Введите первое число диапазона: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите последнее число диапазона: ");
int n = Convert.ToInt32(Console.ReadLine());
NaturalNumsRange(m, n);
