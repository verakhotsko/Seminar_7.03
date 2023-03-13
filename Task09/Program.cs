// Пр-ма, которая выводит случайное число из отрезка [10; 99]
// и показывает наибольшую цифру числа.

int number = new Random().Next(10, 100);
Console.WriteLine($"Случайное число из отрезка [10;99]: {number}.");

//int firstDigit = number / 10;
//int secondDigit = number % 10;
//if (secondDigit > firstDigit) 
 //  Console.WriteLine($"Наибольшая цифра числа {number}: {secondDigit}.");
//else if (secondDigit == firstDigit) 
  // Console.WriteLine($"В числе {number} обе цифры равны.");
//else 
  // Console.WriteLine($"Наибольшая цифра числа {number}: {firstDigit}.");
  
///////////////////////////////////////////////////////////////////////////

   //int maxDigit = firstDigit > secondDigit ? firstDigit : secondDigit; //тернарный оператор
   //Console.WriteLine($"Наибольшая цифра числа {number}: {maxDigit}.");

// при помощи метода:

int result = MaxDigit(number);
Console.WriteLine($"Наибольшая цифра числа {number}: {result}.");

int MaxDigit(int num)    // название метода, тип переменной и переменная
{
    int firstDigit = num / 10;
    int secondDigit = num % 10;
    int maxDigit = firstDigit > secondDigit ? firstDigit : secondDigit;
    return maxDigit;
}