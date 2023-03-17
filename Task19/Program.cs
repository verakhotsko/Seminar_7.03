// Пр-ма, которая на вход принимает пятизначное число и
// проверяет, является ли оно палиндромом.

bool PalindromFiveDig(int num)
{
    int fiveDig = num % 10;
    int firstDig = num / 10000;
    int fourDig = num % 100 / 10;
    int secondDig = num / 1000 % 10;

    if (fiveDig == firstDig)
    {
        if (fourDig == secondDig)
        return true;
        else return false;
    }
    else return false;
}


Console.WriteLine("Введите целое пятизначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number >= 10000 && number < 100000)
{
    bool result = PalindromFiveDig(number);
    Console.WriteLine(result ? "ЯВЛЯЕТСЯ палиндромом" : "НЕ ЯВЛЯЕТСЯ палиндромом");
}
else 
{
    Console.WriteLine("Введенное число не пятизначное. Введите другое."); 
}
