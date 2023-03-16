// 19. Напишите программу, которая 
// принимает на вход пятизначное число 
// и проверяет, является ли оно палиндромом.
// Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.Write("Введите пятизначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

bool isFiveDigit = IsFiveDigit(number);

if (isFiveDigit)
{
    bool palindrome = Palindrome(number);

    string result = palindrome ? $"{number} -> да" : $"{number} -> нет";
    Console.WriteLine(result);

}
else
{
    Console.WriteLine($"Введите число, соответствующее требованию задачи");
}


bool IsFiveDigit(int number)
{
    int result = number / 10000;
    return result != 0 && result >= -9 && result <= 9;
}

bool Palindrome(int number)
{
    int fifthNumber = number % 10;
    int num1 = number / 10;
    int fourthNumber = num1 % 10;
    int num2 = num1 / 100;
    int secondNumber = num2 % 10;
    int firstNumber = num2 / 10;

    return firstNumber == fifthNumber && secondNumber == fourthNumber;
}
