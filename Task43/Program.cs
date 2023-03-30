// 43. Напишите программу, которая найдёт точку пересечения двух прямых, 
//  заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
//  значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.Write("Введите значение b1: ");
double b1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите значение k1: ");
double k1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите значение b2: ");
double b2 = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите значение k2: ");
double k2 = Convert.ToDouble(Console.ReadLine());

bool isIntersectingLine = IsIntersectingLine(k1, k2, b1, b2);
if (isIntersectingLine) {
    double x = FindX(b1, k1, b2, k2);
    double y = FindY(k1, b1, x);

    Console.WriteLine($"b1 = {b1}, k1 = {k1}, b2 = {b2}, k2 = {k1} -> ({x}; {y})");
}
else
{
    Console.WriteLine("Прямые совпадают или параллельны");
}

bool IsIntersectingLine(double k1, double k2, double b1, double b2)
{
    if (k1 == k2) {
        if (b1 == b2) {
            return false;
        } else {
            return false;
        }
    }

    return true;
}

double FindX(double b1, double k1, double b2, double k2)
{
    double result = (b1 - b2) / (k2 - k1);
    
    return Math.Round(result, 1);
}

double FindY(double k1, double b1, double x)
{
    double result = k1 * x + b1;

    return Math.Round(result, 1);
}
