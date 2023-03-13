// 4. Напишите программу, которая принимает на вход три числа 
// и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.Write("Введите первое число: ");
int a = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число: ");
int b = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите треть число: ");
int c = Convert.ToInt32(Console.ReadLine());

int max = 0;

if (a > b)
{
    max = a;
}
else
{
    max = b;
}

if (c > max)
{
    max = c;
}

Console.WriteLine($"Число {max} является максимальным");
