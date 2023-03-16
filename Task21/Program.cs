// 21. Напишите программу, которая 
// принимает на вход координаты двух точек
// и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.Write("Введите координату первой точки по x: ");
int number1x = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату первой точки по y: ");
int number1y = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату первой точки по z: ");
int number1z = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите координату второй точки по x: ");
int number2x = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату второй точки по y: ");
int number2y = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату второй точки по z: ");
int number2z = Convert.ToInt32(Console.ReadLine());

double result = Distance(number1x, number2x,
                        number1y, number2y,
                        number1z, number2z);
double resRound = Math.Round(result, 2, MidpointRounding.ToZero);
Console.WriteLine($"Расстояние между точками в 3D равно {resRound}");

double Distance(int x1, int x2, int y1, int y2, int z1, int z2)
{
    int x = x1 - x2;
    int y = y1 - y2;
    int z = z1 - z2;
    double c = Math.Sqrt(x * x + y * y + z * z);
    return c;
}
