// 67. Напишите программу, которая будет принимать на вход число и
// возвращать сумму его цифр.
// 453 -> 12
// 45 -> 9

// int FactorialRec(int n)
// {
// if (n == 1) return 1;
// else return n * FactorialRec(n - 1);
// }

// Console.WriteLine(FactorialRec(10)); // 3628800

Console.Write($"Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int sum = SumDigits(number);

int SumDigits(int num)
{
    if (num == 0) return 0;
    else return SumDigits(num / 10) + num % 10;
}
Console.WriteLine($"Сумма цифр числа: {sum}");
