// Пр-ма, которая выводит третью цифру числа или
// сообщает, что третьей цифры нет.

// Метод
int TrirdDigital(int num)
{
    int thirdNum = num % 10;
    if (num > 99 && num < 999)
    Console.WriteLine(thirdNum);
    else Console.WriteLine("В этом числе нет третьей цифры.");
    
    return thirdNum;
}
//Программ
Console.WriteLine("Введите число в диапазоне [10; 999]");
int number = Convert.ToInt32(Console.ReadLine());
//int result = number % 10;
//if (number > 99) Console.WriteLine(result);
//else Console.WriteLine("В этом числе нет третьей цифры.");
Console.WriteLine(TrirdDigital(number));