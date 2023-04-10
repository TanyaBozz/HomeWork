﻿// 65. Задайте значения M и N. 
// Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5 -> "1, 2, 3, 4, 5"
// M = 4; N = 8 -> "4, 5, 6, 7, 8"

Console.WriteLine($"Введите первое целое положительное число");
int m = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Введите второе целое положительное число");
int n = Convert.ToInt32(Console.ReadLine());


NaturalNumRange(m, n);

void NaturalNumRange(int num1, int num2)
{
    if (num1 < num2)
    {
        Console.Write($"{num1} ");
        NaturalNumRange(num1 + 1, num2);
    }
    else if (num1 > num2)
    {
        Console.Write($"{num1} ");
        NaturalNumRange(num1 - 1, num2);
    }
    else
    {
        Console.WriteLine("Числа равны");
    }
}

