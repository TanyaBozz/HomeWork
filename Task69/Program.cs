﻿// 69. Напишите программу, которая на вход принимает два числа A и B, и
// возводит число А в целую степень B с помощью рекурсии.
// A = 3; B = 5 -> 243 (3⁵)
// A = 2; B = 3 -> 8

Console.Write($"Введите первое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.Write($"Введите второе число: ");
int num2 = Convert.ToInt32(Console.ReadLine());

int numDegree = NumDegree(num1, num2);

int NumDegree(int num1, int num2)
{
    if (num2 == 0 ) return 1;
    else return num1 * (NumDegree(num1, num2 - 1));
}
Console.WriteLine($"Результат -> {numDegree}");
