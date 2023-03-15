//Пр-ма, котора принимает на вход число и 
// проверяет кратно ли оно одновременно 7 и 23.

//Console.WriteLine("Введите целое положительное число: ");
//int number = Convert.ToInt32(Console.ReadLine());
//if (number % 7 == 0)
//{
//    if (number % 23 == 0) Console.WriteLine("Кратно.");
//}
//else Console.WriteLine("Не кратно.");

//////////////////////////////////////////////////////////
// Метод:
//string Multiple(int num)
//{
//    int result1 = num % 7;
//    int result2 = num % 23;
//    string answer;
//    if (result1 == 0)
//    {
//            if  (result2 == 0)  answer = Convert.ToString("Кратно");
//            else answer = Convert.ToString("Не кратно");
//    } 
//    else answer = Convert.ToString("Не кратно");
//        return answer;
//}

//Console.WriteLine("Введите целое положительное число: ");
//int number = Convert.ToInt32(Console.ReadLine());
//string answer;
//if (Multiple(number) == answer)
//Console.WriteLine("Кратно");
//else Console.WriteLine("Не кратно");

/////////////////////////////////////////////////////////////////////////////////
bool MultiplTwoNumb( int num, int num1, int num2)
{
     return num % num1 == 0 && num % num2 == 0; // универсальность приветствуется
}

Console.WriteLine("Введите целое положительное число: ");
int number = Convert.ToInt32(Console.ReadLine());
bool result  = MultiplTwoNumb(number, 7, 23);
Console.WriteLine(result ? "Кратно" : "Не кратно");
