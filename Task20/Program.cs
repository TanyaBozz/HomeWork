// 20. Напишите программу, которая
// принимает на вход координаты двух точек и
// находит расстояние между ними в 2D
// пространстве.
// A (3,6); B (2,1) -> 5,09
// A (7,-5); B (1,-1) -> 7,21

Console.Write("Введите координату первой точки по x: ");
int num1X = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату первой точки по y: ");
int num1Y = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите координату второй точки по x: ");
int num2X = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату второй точки по y: ");
int num2Y = Convert.ToInt32(Console.ReadLine());

double result = Distance(num1X, num2X, num1Y, num2Y);
double resRound = Math.Round(result, 2, MidpointRounding.ToZero);
Console.WriteLine($"Расстояние между точками равно {resRound}");

double Distance(int x1, int y1, int x2, int y2)
{
    int x = x1 - x2;
    int y = y1 - y2;
    double c = Math.Sqrt(x * x + y * y);
    return c;
}
