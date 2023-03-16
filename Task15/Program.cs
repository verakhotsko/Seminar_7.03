// Пр-ма, которая на вход принимает цифру, обозначающую день недели
// и на выход проверяет, является ли эта цифра выходным.

//Console.WriteLine("Введите цифру от 1 до 7, включительно: ");
//int number = Convert.ToInt32(Console.ReadLine());
//if (number > 5)Console.WriteLine("да, выходной");
//else Console.WriteLine("нет, рабочий");

// Решение от GeekBrains:
int Prompt(string message)            //метод конвертирующий текст в число
{
    Console.Write(message);
    string value = Console.ReadLine();
    int result = Convert.ToInt32(value);
    return result;
}

bool IsWeekend(int weekDay)
{
    if(weekDay > 5)
    {
        return true;
    }
    return false;
}

bool ValidateWeekday(int number)
{
    if (number > 0 && number <= 7)
    {
        return true;
    }
    Console.WriteLine("Это не день недели!");
    return false;
}

int weekDay = Prompt("Введите день недели ");
if (ValidateWeekday(weekDay))
{
    if (IsWeekend(weekDay))
    {
        Console.WriteLine("Выходной");
    }
    else
    {
        Console.WriteLine("Рабочий");
    }
}