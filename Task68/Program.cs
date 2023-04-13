// 68. Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

Console.Write($"Введите первое целое положительное число: ");
int m = Convert.ToInt32(Console.ReadLine());
bool isNotNegativeNumM = IsNotNegativeNum(m);
if (!isNotNegativeNumM)
{
    Console.WriteLine($"{m} -> не является положительным числом!!!");
    return;
}

Console.Write($"Введите второе целое положительное число: ");
int n = Convert.ToInt32(Console.ReadLine());
bool isNotNegativeNumN = IsNotNegativeNum(n);
if (!isNotNegativeNumN)
{
    Console.WriteLine($"{n} -> не является положительным числом!!!");
    return;
}

int ack = Ack(m, n);
Console.WriteLine($"m = {m}, n = {n} -> A(m,n) = {ack}");

bool IsNotNegativeNum(int num)
{
    return num >= 0;
}

int Ack(int num1, int num2)
{
    while (num1 != 0)
    {
        if (num2 == 0)
        {
            num2 = 1;
        }
        else
        {
            num2 = Ack(num1, num2 - 1);
        }
        num1 = num1 - 1;
    }
    return num2 + 1;
}
