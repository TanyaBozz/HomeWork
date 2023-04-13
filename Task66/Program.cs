//  66. Задайте значения M и N. 
//  Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.Write($"Введите первое целое положительное число: ");
int m = Convert.ToInt32(Console.ReadLine());
bool isNaturalNumbersM = IsNaturalNumbers(m);
if (!isNaturalNumbersM)
{
    Console.WriteLine($"{m} -> не является натуральным числом!!!");
    return;
}

Console.Write($"Введите второе целое положительное число: ");
int n = Convert.ToInt32(Console.ReadLine());
bool isNaturalNumbersN = IsNaturalNumbers(n);
if (!isNaturalNumbersN)
{
    Console.WriteLine($"{n} -> не является натуральным числом!!!");
    return;
}

int sumNaturalNum = SumNaturalNum(m, n);

Console.WriteLine($"M = {m}; N = {n} -> {sumNaturalNum}");

bool IsNaturalNumbers(int num)
{
    return num > 0;
}

int SumNaturalNum(int num1, int num2)
{
    if (num1 < num2)
    {
        return num1 + SumNaturalNum(num1 + 1, num2);
    }
    else if (num1 > num2)
    {
        return num2 + SumNaturalNum(num1, num2 + 1);
    }
    else
    {
        return num1;
    }
}
