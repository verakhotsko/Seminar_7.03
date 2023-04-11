// Задайте значение N.
// Пр-ма, которая выведет все натуральные числа в 
// промежутке от 1 до N.

// метод-рекурсия, выводящий числа в заданном промежутке:

void NaturalNums(int num)
{
    if(num == 0) return;
    NaturalNums (num - 1);
    Console.Write($"{num} ");
}

Console.Write("Введите целое положительное число: ");
int number = Convert.ToInt32(Console.ReadLine());
NaturalNums(number);