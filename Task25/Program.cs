// Напишите программу, которая принимает на вход два числа (A и B) и 
// возводит число A в натуральную степень B.

// метод возводящий в степень В число А:

int Degree(int num1, int num2)
{
    if (num2 == 0)
    {
        return 1;
    }
    else
    {
        int result = num1;
        for (int i = 2; i <= num2; i++)
        {
            result = result * num1;
        }
        return result;
    }
}
Console.WriteLine("Введите первое число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int number2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(Degree(number1, number2));