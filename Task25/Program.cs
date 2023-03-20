//  25. Напишите цикл, который 
//  принимает на вход два числа (A и B) и 
//  возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.Write("Введите первое число: ");
int numberOne = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число: ");
int numberTwo = Convert.ToInt32(Console.ReadLine());
bool isNaturalNumber = IsNaturalNumber(numberTwo);
if (isNaturalNumber) 
{
    int pow = Pow(numberOne, numberTwo);
    Console.WriteLine($" {numberOne} в степени {numberTwo} -> {pow}");
}
else
{
    Console.WriteLine($"Второе число не должно быть меньше 0!!!");
}

int Pow(int number, int degree)
{
    int result = 1;
    for (int i = 1; i <= degree; i++)
    {
        result *= number;    //result = number * number;
    }
    return result;
}

bool IsNaturalNumber(int number)
{
    if (number < 0)
    {
        return false;
    }
    return true;
}
