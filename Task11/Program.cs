// Пр-ма, которая выводит случайное трёхзначное число
// и удаляет вторую цифру этого числа.


int DelSecDig(int num)
{
    int numFirst = num / 100;
    int numLast = num % 10;
    int delSecDig = numFirst * 10 + numLast;
    return delSecDig;
}

int number = new Random().Next(100, 999);

Console.WriteLine($"Случайное трёхзначное число: {number}.");
Console.WriteLine($"Двухзначное число: {DelSecDig(number)}.");
