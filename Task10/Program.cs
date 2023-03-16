//  10. Напишите программу, которая принимает на вход трёхзначное число
//  и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.Write("Введите трехзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

bool isThreeDigit = IsThreeDigit(number);
if (isThreeDigit)
{
   int result = SecondNumber(number);
   Console.WriteLine($"Вторая цифра -> {result}");
}
else
{
    Console.WriteLine("Введите ТРЕХЗНАЧНОЕ ЧИСЛО!!! ");
}

bool IsThreeDigit(int number)
{
    int result = number / 100;
    return result != 0 && result >= -9 && result <= 9;
}

int SecondNumber(int number)
{
    return number / 10 % 10;
}

