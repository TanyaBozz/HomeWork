// 15. Напишите программу, которая принимает на вход цифру,
// обозначающую день недели,
// и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

Console.Write("Введите цифру, обозначающую день недели: ");
int number = Convert.ToInt32(Console.ReadLine());

bool dayWeek = DayWeek(number);
bool dayOff = DayOff(number);

if (dayWeek)
{
    if (dayOff)
    {
        Console.Write($"{number} -> да, выходной");
    }
    else
    {
        Console.Write($"{number} -> нет, не выходной");
    }
}
else
{
    Console.Write("Введите цифру, соответствующую дню недели!!! ");
}


bool DayWeek(int number)
{
    return number >= 1 && number <= 7;
}

bool DayOff(int number)
{
    return number == 6 || number == 7;
}
