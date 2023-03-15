// 13: Напишите программу, которая выводит третью цифру заданного числа
//  или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

bool isThreeDigit = IsThreeDigit(number);
bool overThreeDigit = OverThreeDigit(number);

if (isThreeDigit)
{
    int result = LastNumber(number);
    Console.WriteLine($"Третья цифра -> {result}");
}
else if (overThreeDigit)
{
    int findThree = FindThree(number);
    int result = LastNumber(findThree);
    Console.WriteLine($"Третья цифра -> {result}");
}
else
{
    Console.WriteLine($"Третьей цифры НЕТ");
}

bool IsThreeDigit(int number)
{
    int result = number / 100;
    return result != 0 && result >= -9 && result <= 9;
}

int LastNumber(int number)
{
    return number % 10;
}

bool OverThreeDigit(int number)
{
    int result = number / 100;

    return result != 0 && (result >= 10 || result <= -10);
}

int FindThree(int number)
{
    while (number > 999 || number < -999)
    {
        number = number / 10;
    }
    return number;
}
