// Пр-ма, которая будет переобразовывать
// десятичное число в двоичное.
// 1) остаток от деления на 2
// 2) результат вновь делим на 2 и записываем остаток 
// 3) повторяем операцию пока результат будет = нулю.
// 4) записать полученные остатки в обратном порядке.

// метод

string BinaryNum(int num)
{
if(num == 0 || num == 1)
{
    return Convert.ToString(num);
}

    string binary = string.Empty;
    while (num != 0)
    {
        binary = num % 2 + binary; // остаток от деления - двоичное число
        num = num / 2; // уменьшаем само число 
    }
    return binary;
}

// сама программа
Console.Write("Введите деятичное число ");
int dec = Convert.ToInt32(Console.ReadLine());
string result = BinaryNum(dec);
Console.WriteLine(result);